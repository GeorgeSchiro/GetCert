Overview
========


**GetCert** is simple and **FREE** software for automating digital certificate retrieval and installation (screenshots below).

This utility gets a digital certificate from the **FREE** "Let's Encrypt" certificate provider network (see "LetsEncrypt.org"). It installs the certificate in your server's local computer certificate store and binds it to port 443 in IIS.

If the current time is not within a given number of days prior to expiration of the current digital certificate (eg. 30 days, see -ExpirationDaysBeforeRenewal below), this software does nothing. Otherwise, the retrieval process begins. If "stand-alone" mode is disabled (see -UseStandAloneMode below), the certificate retrieval process is used in concert with the secure certificate service (SCS), see "SafeTrust.org".

If the software is not running in "stand-alone" mode, it also copies any new cert to a file anywhere on the local area network to be picked up by the load balancer administrator or process. It also replaces the SSO (single-sign-on) certificate in your central SSO configuration (ie. ADFS) and restarts the SSO service on all servers in any defined SSO server farm. It also replaces all integrated application SSO certificate references in any number of configuration files anywhere on the local network.

Also when -UseStandAloneMode is False, this software checks for any previously fetched certificate (by another client running the same software). If found, it is downloaded directly from the SCS (rather than attempting retrieval from the certificate provider network). If not found on the SCS, a certificate is requested from the certificate provider network, uploaded to the SCS (for use by other clients in the same server farm) and installed locally and bound to port 443 in IIS. Finally, calls to the certificate provider network can be overridden by providing this software access to a digital certificate file anywhere on the local network.

Give it a try.

The first time you run "GetCert.exe" it will prompt you to create a "GetCert" folder on your desktop. It will copy itself and continue running from there.

Everything the software needs is written to the "GetCert" folder. Nothing is written anywhere else.

If you like the software, you can leave it on your desktop or you can run "Setup Application Folder.exe" (also in the "GetCert" folder, be sure to run it as administrator). If you decide not to keep the software, simply delete the "GetCert" folder from your desktop.


Features
========


-   Simple setup - try it out fast
-   Only two website details needed to get started
-   Performs extensive handshaking with the "Let's Encrypt"
    certificate network, all completely automatically
-   Installs a new certificate and binds it to port 443 in IIS
-   Comprehensive dated log files are produced with every run
-   Can be command-line driven from a server batch job scheduler
-   Software is highly configurable
-   Software is totally self-contained (EXE is its own setup)


**GetCert** is essentially an automation front-end for "ACMESharp". "ACMESharp" is an excellent tool. That said, you can replace it with any other Powershell capable ACME protocol tool you might prefer instead. Such a change would be made in the profile file like everything else (see -ACMESharpPath, -ScriptStage1, etc. below).


Screenshots
===========


![Copy EXE to Desktop?](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot0.PNG)
![Setup Wizard        ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot1.PNG)
![Setup Wizard Step 1 ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot2.PNG)
![Setup Wizard Done   ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot3.PNG)
![Run Process Prompt  ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot4.PNG)
![Process Running 1   ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot5.PNG)
![Process Running 2   ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot6.PNG)
![Process Finished    ](https://raw.githubusercontent.com/GeorgeSchiro/GetCert/master/Project/Screenshots/Shot7.PNG)


Requirements
============


-   Windows Server 2008 R2+
-   Internet Information Services (IIS)


Command-Line Usage
==================


Open this utility's profile file to see additional options available. It is usually located in the same folder as "GetCert.exe" and has the same name with ".config" added (see "GetCert.exe.config").

Profile file options can be overridden with command-line arguments. The keys for any "-key=value" pairs passed on the command-line must match those that appear in the profile (with the exception of the "-ini" key).

For example, the following invokes the use of an alternative profile file:

    GetCert.exe -ini=NewProfile.txt

This tells the software to run in automatic mode:

    GetCert.exe -Auto


Author:  George Schiro (GeoCode@SafeTrust.org)

Date:    4/27/2017




Options and Features


The main options for this utility are listed below with their default values. A brief description of each feature follows.

-ACMESharpModuleUseGallery=False

    Set this switch True and the "Powershell Gallery" version of "ACMESharp"
    will be used in lieu of the version embedded in the EXE (see -ACMESharpPath
    below).

-ACMESharpPath="ACMESharp"

    "ACMESharp" is the primary tool used by this utility to communicate
    with the "Let's Encrypt" certificate network. By default, this key is
    set to the "ACMESharp" folder which, with no absolute path given, will
    be expected to be found within the folder that contains "GetCert.exe.config".
    Set -ACMESharpModuleUseGallery=True (see above) and the OS will look to
    find "ACMESharp" in its usual place as a module in the Powershell gallery.

-AdfsThumbprintFiles="C:\inetpub\wwwroot\web.config"

    This is the path and filename of files that will have their ADFS certificate
    thumbprint replaced whenever the related ADFS certificate changes. Any files
    with the same name at all levels of the directory hierarchy may be updated,
    starting with the given base path. Wildcards may be used in the filename.

    This key may appear any number of times in the profile.

-Auto=False

    Set this switch True to run this utility one time (with no interactive UI)
    then shutdown automatically upon completion. This switch is useful if this
    software is run in a batch process or by a server job scheduler.

-CertificateDomainName= NO DEFAULT VALUE

    This is the subject name (ie. DNS name) of the certificates returned.

-CertificatePrivateKeyExportable=False

    Set this switch True (not recommended) to allow certificate private keys
    to be exportable from the local certificate store to a local disk file.
    Any SA with server access has access to the certificate's private key.

-CertificateRenewalDateOverride= NO DEFAULT VALUE

    Set this date value to override the date calculation that subtracts
    -ExpirationDaysBeforeRenewal days (see below) from the current certificate
    expiration date to know when to start fetching a new certificate.

-ContactEmailAddress= NO DEFAULT VALUE

    This is the contact email address the certificate network uses to send
    certificate expiration notices.

-DoStagingTests=True

    Initial testing is done with the certificate provider staging network. Set
    this switch False to use the live production certificate network.

-ExpirationDaysBeforeRenewal=30

    This is the number of days until certificate expiration before automated
    gets of the next new certificate are attempted.

-FetchSource=False

    Set this switch True to fetch the source code for this utility from the EXE.
    Look in the containing folder for a ZIP file with the full project sources.

-Help= SEE PROFILE FOR DEFAULT VALUE

    This help text.

-KillProcessForcedWaitMS=1000

    This is the maximum milliseconds to wait while force killing a process.

-KillProcessOrderlyWaitSecs=10

    This is the maximum number of seconds given to a process after a "close"
    command is given before the process is forcibly terminated.

-LogEntryDateTimeFormatPrefix="yyyy-MM-dd hh:mm:ss:fff tt  "

    This format string is used to prepend a timestamp prefix to each log entry
    in the process log file (see -LogPathFile below).    

-LogFileDateFormat="-yyyy-MM-dd"

    This format string is used to form the variable part of each log file output 
    filename (see -LogPathFile below). It is inserted between the filename and 
    the extension.

-LogPathFile="Logs\GetCert.exeLog.txt"

    This is the output path\file that will contain the process log. The profile
    filename will be prepended to the default filename (see above) and the current
    date (see -LogFileDateFormat above) will be inserted between the filename and
    the extension.

-MaxCertRenewalLockDelaySecs=300

    Wait a random period each cycle (at most this many seconds) to allow different
    clients the opportunity to lock the certificate renewal (ie. only one client
    at a time per domain can communicate with the certificate provider network).

-NoPrompts=False

    Set this switch True and all pop-up prompts will be suppressed. Messages
    are written to the log instead (see -LogPathFile above). You must use this
    switch whenever the software is run via a server computer batch job or job
    scheduler (ie. where no user interaction is permitted).

-PowerScriptPathFile=PowerScript.ps1

    This is the path\file location of the current (ie. temporary) Powershell script
    file.

-PowerScriptSleepMS=200

    This is the number of sleep milliseconds between loops while waiting for the
    Powershell script process to complete.

-PowerScriptTimeoutSecs=300

    This is the maximum number of seconds allocated to any Powershell script
    process to run prior to throwing a timeout exception.

-PowershellExeArgs=-NoProfile -ExecutionPolicy unrestricted -File "{0}"

    These are the arguments passed to the windows Powershell EXE (see below).
    The one replacement token (ie. "{0}") is replaced with -PowerScriptPathFile
    (see above).

-PowershellExePathFile=C:\Windows\System32\WindowsPowershell\v1.0\powershell.exe

    This is the path\file location of the windows Powershell EXE.

-RemoveReplacedCert=False

    Set this switch True and the old (ie. previously bound) certificate will be
    removed whenever a new retrieved certificate is bound to replace it.

    Note: this switch applies only when -UseStandAloneMode is True.

-ReplaceTextSleepMS=200

    This is the number of sleep milliseconds between loops while waiting for the
    ADFS text replacement process to complete.

-ReplaceTextTimeoutSecs=120

    This is the maximum number of seconds allocated to the ADFS text replacement
    process to run prior to throwing a timeout exception.

-ResetStagingLogs=True

    Having to wade through several log sessions during testing can be cumbersome.
    So the default behavior is to clear the log file after it is uploaded to the SCS
    server (following each test). Setting this switch False will retain all previous
    log sessions on the client during testing.

-SanList= SEE PROFILE FOR DEFAULT VALUE

    This is the SAN list (subject alternative names) to appear on the certificate
    when it is generated. It will consist of -CertificateDomainName by default (see
    above). This list can be edited here directly or through the "SAN List" button
    in the GetCert.exe UI. Click the "SAN List" button to see the proper format here.

    Note: the GetCert.exe UI limits you to 100 SAN values (the certificate provider
          does the same). If you add more names than this limit, an error results
          and no certificate will be generated.

-SaveProfile=True

    Set this switch False to prevent saving to the profile file by this utility
    software itself. This is not recommended since process status information is 
    written to the profile after each run.

-SaveSansCmdLine=True

    Set this switch False to leave the profile file untouched after a command line
    has been passed to the EXE and merged with the profile. When true, everything
    but command line keys will be saved. When false, not even status information
    will be written to the profile file (ie. "GetCert.exe.config").

-ScriptADFS= SEE PROFILE FOR DEFAULT VALUE

    This is the Powershell script that updates ADFS servers with new certificates.

-ScriptStage1= SEE PROFILE FOR DEFAULT VALUE

    There are multiple stages involved with the process of getting a certificate
    from the certificate network. Each stage has an associated Powershell script.
    The stages are represented in this profile by -ScriptStage1 thru -ScriptStage8.

-ServiceReportEverything=True

    By default, all activity logged on the client during non-interactive mode
    is uploaded to the SCS server. This can be very helpful during automation
    testing. Once testing is complete, set this switch False to report errors
    only, thereby saving a considerable amount of network bandwidth.

    Note: "non-interactive mode" means the -Auto switch is set (see above).

-ServiceUrlLive="https://acme-v01.api.letsencrypt.org/"

    This is the URL to the live production certificate network.

-ServiceUrlStaging="https://acme-staging.api.letsencrypt.org/"

    This is the URL to the non-production (ie. "staging") certificate network.

-ShowProfile=False

    Set this switch True to immediately display the entire contents of the profile
    file at startup in command-line format. This may be helpful as a diagnostic.

-SkipAdfsServer=False

    When a client is on an ADFS domain (ie. it's a member of an ADFS server farm),
    it will automatically attempt to update ADFS services with each new certificate
    retrieved. Set this switch True to disable ADFS updates (for this client only).

-SkipAdfsThumbprintUpdates=False

    When a client's domain references an ADFS domain, the client will automatically
    attempt to update configuration files with each new ADFS certificate thumbprint.
    Set this switch True to disable ADFS thumbprint configuration updates (for this
    client only).

-SubmissionRetries=999

    Pending submissions to the certificate provider network will be retried until
    they succeed or fail, by default, at most this many times.

-SubmissionWaitSecs=5

    These are the seconds of wait time after the DNS website challenge has been
    submitted to the certificate network as well as after the certificate request
    has been submitted. This is the amount of time during which the request should
    transition from a "pending" state to anything other than "pending".

-UseStandAloneMode=True

    Set this switch False and the software will use the SafeTrust Secure Certificate
    Service (see "SafeTrust.org") to manage certificates between several servers
    in a server farm, SSO servers, SSO integrated application servers and load
    balancers.


Notes:

    There may be various other settings that can be adjusted also (user
    interface settings, etc). See the profile file ("GetCert.exe.config")
    for all available options.

    To see the options related to any particular behavior, you must run that
    part of the software first. Configuration options are added "on the fly"
    (in order of execution) to "GetCert.exe.config" as the software runs.

