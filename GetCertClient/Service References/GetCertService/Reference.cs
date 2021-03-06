﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetCert.GetCertService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GetCertService.IGetCertService")]
    public interface IGetCertService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bLockCertificateRenewal", ReplyAction="http://tempuri.org/IGetCertService/bLockCertificateRenewalResponse")]
        bool bLockCertificateRenewal(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bLockCertificateRenewal", ReplyAction="http://tempuri.org/IGetCertService/bLockCertificateRenewalResponse")]
        System.Threading.Tasks.Task<bool> bLockCertificateRenewalAsync(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bUnlockCertificateRenewal", ReplyAction="http://tempuri.org/IGetCertService/bUnlockCertificateRenewalResponse")]
        bool bUnlockCertificateRenewal(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bUnlockCertificateRenewal", ReplyAction="http://tempuri.org/IGetCertService/bUnlockCertificateRenewalResponse")]
        System.Threading.Tasks.Task<bool> bUnlockCertificateRenewalAsync(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bNewCertificateUploaded", ReplyAction="http://tempuri.org/IGetCertService/bNewCertificateUploadedResponse")]
        bool bNewCertificateUploaded(string asHash, string asProfile, byte[] abtArrayCertificate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bNewCertificateUploaded", ReplyAction="http://tempuri.org/IGetCertService/bNewCertificateUploadedResponse")]
        System.Threading.Tasks.Task<bool> bNewCertificateUploadedAsync(string asHash, string asProfile, byte[] abtArrayCertificate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bOldCertificateRemoved", ReplyAction="http://tempuri.org/IGetCertService/bOldCertificateRemovedResponse")]
        bool bOldCertificateRemoved(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/bOldCertificateRemoved", ReplyAction="http://tempuri.org/IGetCertService/bOldCertificateRemovedResponse")]
        System.Threading.Tasks.Task<bool> bOldCertificateRemovedAsync(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayGetCertExeUpdate", ReplyAction="http://tempuri.org/IGetCertService/btArrayGetCertExeUpdateResponse")]
        byte[] btArrayGetCertExeUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayGetCertExeUpdate", ReplyAction="http://tempuri.org/IGetCertService/btArrayGetCertExeUpdateResponse")]
        System.Threading.Tasks.Task<byte[]> btArrayGetCertExeUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayGoPcBackupExeUpdate", ReplyAction="http://tempuri.org/IGetCertService/btArrayGoPcBackupExeUpdateResponse")]
        byte[] btArrayGoPcBackupExeUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayGoPcBackupExeUpdate", ReplyAction="http://tempuri.org/IGetCertService/btArrayGoPcBackupExeUpdateResponse")]
        System.Threading.Tasks.Task<byte[]> btArrayGoPcBackupExeUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayNewCertificate", ReplyAction="http://tempuri.org/IGetCertService/btArrayNewCertificateResponse")]
        byte[] btArrayNewCertificate(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/btArrayNewCertificate", ReplyAction="http://tempuri.org/IGetCertService/btArrayNewCertificateResponse")]
        System.Threading.Tasks.Task<byte[]> btArrayNewCertificateAsync(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sCfgUpdate", ReplyAction="http://tempuri.org/IGetCertService/sCfgUpdateResponse")]
        string sCfgUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sCfgUpdate", ReplyAction="http://tempuri.org/IGetCertService/sCfgUpdateResponse")]
        System.Threading.Tasks.Task<string> sCfgUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sDomainProfile", ReplyAction="http://tempuri.org/IGetCertService/sDomainProfileResponse")]
        string sDomainProfile(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sDomainProfile", ReplyAction="http://tempuri.org/IGetCertService/sDomainProfileResponse")]
        System.Threading.Tasks.Task<string> sDomainProfileAsync(string asHash, string asProfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sGpcIniUpdate", ReplyAction="http://tempuri.org/IGetCertService/sGpcIniUpdateResponse")]
        string sGpcIniUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sGpcIniUpdate", ReplyAction="http://tempuri.org/IGetCertService/sGpcIniUpdateResponse")]
        System.Threading.Tasks.Task<string> sGpcIniUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sHostsEntryUpdate", ReplyAction="http://tempuri.org/IGetCertService/sHostsEntryUpdateResponse")]
        string sHostsEntryUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sHostsEntryUpdate", ReplyAction="http://tempuri.org/IGetCertService/sHostsEntryUpdateResponse")]
        System.Threading.Tasks.Task<string> sHostsEntryUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sIniUpdate", ReplyAction="http://tempuri.org/IGetCertService/sIniUpdateResponse")]
        string sIniUpdate(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/sIniUpdate", ReplyAction="http://tempuri.org/IGetCertService/sIniUpdateResponse")]
        System.Threading.Tasks.Task<string> sIniUpdateAsync(string asHash, string asProfile, string asInstalledVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ClientCheckIn", ReplyAction="http://tempuri.org/IGetCertService/ClientCheckInResponse")]
        void ClientCheckIn(string asHash, string asProfile, string asErrorLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ClientCheckIn", ReplyAction="http://tempuri.org/IGetCertService/ClientCheckInResponse")]
        System.Threading.Tasks.Task ClientCheckInAsync(string asHash, string asProfile, string asErrorLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/NotifyLoadBalancerCertificate", ReplyAction="http://tempuri.org/IGetCertService/NotifyLoadBalancerCertificateResponse")]
        void NotifyLoadBalancerCertificate(string asHash, string asProfile, string asLoadBalancerComputer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/NotifyLoadBalancerCertificate", ReplyAction="http://tempuri.org/IGetCertService/NotifyLoadBalancerCertificateResponse")]
        System.Threading.Tasks.Task NotifyLoadBalancerCertificateAsync(string asHash, string asProfile, string asLoadBalancerComputer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ReportErrors", ReplyAction="http://tempuri.org/IGetCertService/ReportErrorsResponse")]
        void ReportErrors(string asHash, string asProfile, string asErrorLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ReportErrors", ReplyAction="http://tempuri.org/IGetCertService/ReportErrorsResponse")]
        System.Threading.Tasks.Task ReportErrorsAsync(string asHash, string asProfile, string asErrorLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ReportEverything", ReplyAction="http://tempuri.org/IGetCertService/ReportEverythingResponse")]
        void ReportEverything(string asHash, string asProfile, string asClientLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/ReportEverything", ReplyAction="http://tempuri.org/IGetCertService/ReportEverythingResponse")]
        System.Threading.Tasks.Task ReportEverythingAsync(string asHash, string asProfile, string asClientLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/SetAdfsThumbprint", ReplyAction="http://tempuri.org/IGetCertService/SetAdfsThumbprintResponse")]
        void SetAdfsThumbprint(string asHash, string asProfile, string asAdfsThumbprint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetCertService/SetAdfsThumbprint", ReplyAction="http://tempuri.org/IGetCertService/SetAdfsThumbprintResponse")]
        System.Threading.Tasks.Task SetAdfsThumbprintAsync(string asHash, string asProfile, string asAdfsThumbprint);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetCertServiceChannel : GetCert.GetCertService.IGetCertService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCertServiceClient : System.ServiceModel.ClientBase<GetCert.GetCertService.IGetCertService>, GetCert.GetCertService.IGetCertService {
        
        public GetCertServiceClient() {
        }
        
        public GetCertServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetCertServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetCertServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetCertServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool bLockCertificateRenewal(string asHash, string asProfile) {
            return base.Channel.bLockCertificateRenewal(asHash, asProfile);
        }
        
        public System.Threading.Tasks.Task<bool> bLockCertificateRenewalAsync(string asHash, string asProfile) {
            return base.Channel.bLockCertificateRenewalAsync(asHash, asProfile);
        }
        
        public bool bUnlockCertificateRenewal(string asHash, string asProfile) {
            return base.Channel.bUnlockCertificateRenewal(asHash, asProfile);
        }
        
        public System.Threading.Tasks.Task<bool> bUnlockCertificateRenewalAsync(string asHash, string asProfile) {
            return base.Channel.bUnlockCertificateRenewalAsync(asHash, asProfile);
        }
        
        public bool bNewCertificateUploaded(string asHash, string asProfile, byte[] abtArrayCertificate) {
            return base.Channel.bNewCertificateUploaded(asHash, asProfile, abtArrayCertificate);
        }
        
        public System.Threading.Tasks.Task<bool> bNewCertificateUploadedAsync(string asHash, string asProfile, byte[] abtArrayCertificate) {
            return base.Channel.bNewCertificateUploadedAsync(asHash, asProfile, abtArrayCertificate);
        }
        
        public bool bOldCertificateRemoved(string asHash, string asProfile) {
            return base.Channel.bOldCertificateRemoved(asHash, asProfile);
        }
        
        public System.Threading.Tasks.Task<bool> bOldCertificateRemovedAsync(string asHash, string asProfile) {
            return base.Channel.bOldCertificateRemovedAsync(asHash, asProfile);
        }
        
        public byte[] btArrayGetCertExeUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.btArrayGetCertExeUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<byte[]> btArrayGetCertExeUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.btArrayGetCertExeUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public byte[] btArrayGoPcBackupExeUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.btArrayGoPcBackupExeUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<byte[]> btArrayGoPcBackupExeUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.btArrayGoPcBackupExeUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public byte[] btArrayNewCertificate(string asHash, string asProfile) {
            return base.Channel.btArrayNewCertificate(asHash, asProfile);
        }
        
        public System.Threading.Tasks.Task<byte[]> btArrayNewCertificateAsync(string asHash, string asProfile) {
            return base.Channel.btArrayNewCertificateAsync(asHash, asProfile);
        }
        
        public string sCfgUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sCfgUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<string> sCfgUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sCfgUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public string sDomainProfile(string asHash, string asProfile) {
            return base.Channel.sDomainProfile(asHash, asProfile);
        }
        
        public System.Threading.Tasks.Task<string> sDomainProfileAsync(string asHash, string asProfile) {
            return base.Channel.sDomainProfileAsync(asHash, asProfile);
        }
        
        public string sGpcIniUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sGpcIniUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<string> sGpcIniUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sGpcIniUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public string sHostsEntryUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sHostsEntryUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<string> sHostsEntryUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sHostsEntryUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public string sIniUpdate(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sIniUpdate(asHash, asProfile, asInstalledVersion);
        }
        
        public System.Threading.Tasks.Task<string> sIniUpdateAsync(string asHash, string asProfile, string asInstalledVersion) {
            return base.Channel.sIniUpdateAsync(asHash, asProfile, asInstalledVersion);
        }
        
        public void ClientCheckIn(string asHash, string asProfile, string asErrorLog) {
            base.Channel.ClientCheckIn(asHash, asProfile, asErrorLog);
        }
        
        public System.Threading.Tasks.Task ClientCheckInAsync(string asHash, string asProfile, string asErrorLog) {
            return base.Channel.ClientCheckInAsync(asHash, asProfile, asErrorLog);
        }
        
        public void NotifyLoadBalancerCertificate(string asHash, string asProfile, string asLoadBalancerComputer) {
            base.Channel.NotifyLoadBalancerCertificate(asHash, asProfile, asLoadBalancerComputer);
        }
        
        public System.Threading.Tasks.Task NotifyLoadBalancerCertificateAsync(string asHash, string asProfile, string asLoadBalancerComputer) {
            return base.Channel.NotifyLoadBalancerCertificateAsync(asHash, asProfile, asLoadBalancerComputer);
        }
        
        public void ReportErrors(string asHash, string asProfile, string asErrorLog) {
            base.Channel.ReportErrors(asHash, asProfile, asErrorLog);
        }
        
        public System.Threading.Tasks.Task ReportErrorsAsync(string asHash, string asProfile, string asErrorLog) {
            return base.Channel.ReportErrorsAsync(asHash, asProfile, asErrorLog);
        }
        
        public void ReportEverything(string asHash, string asProfile, string asClientLog) {
            base.Channel.ReportEverything(asHash, asProfile, asClientLog);
        }
        
        public System.Threading.Tasks.Task ReportEverythingAsync(string asHash, string asProfile, string asClientLog) {
            return base.Channel.ReportEverythingAsync(asHash, asProfile, asClientLog);
        }
        
        public void SetAdfsThumbprint(string asHash, string asProfile, string asAdfsThumbprint) {
            base.Channel.SetAdfsThumbprint(asHash, asProfile, asAdfsThumbprint);
        }
        
        public System.Threading.Tasks.Task SetAdfsThumbprintAsync(string asHash, string asProfile, string asAdfsThumbprint) {
            return base.Channel.SetAdfsThumbprintAsync(asHash, asProfile, asAdfsThumbprint);
        }
    }
}
