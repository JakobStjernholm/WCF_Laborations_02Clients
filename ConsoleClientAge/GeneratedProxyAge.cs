﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://CalculateAgeLibrary", ConfigurationName="ICalculateAgeClass")]
public interface ICalculateAgeClass
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://CalculateAgeLibrary/ICalculateAgeClass/GetDays", ReplyAction="http://CalculateAgeLibrary/ICalculateAgeClass/GetDaysResponse")]
    int GetDays(System.DateTime birthday);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://CalculateAgeLibrary/ICalculateAgeClass/GetDays", ReplyAction="http://CalculateAgeLibrary/ICalculateAgeClass/GetDaysResponse")]
    System.Threading.Tasks.Task<int> GetDaysAsync(System.DateTime birthday);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculateAgeClassChannel : ICalculateAgeClass, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculateAgeClassClient : System.ServiceModel.ClientBase<ICalculateAgeClass>, ICalculateAgeClass
{
    
    public CalculateAgeClassClient()
    {
    }
    
    public CalculateAgeClassClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculateAgeClassClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateAgeClassClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateAgeClassClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int GetDays(System.DateTime birthday)
    {
        return base.Channel.GetDays(birthday);
    }
    
    public System.Threading.Tasks.Task<int> GetDaysAsync(System.DateTime birthday)
    {
        return base.Channel.GetDaysAsync(birthday);
    }
}