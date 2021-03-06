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
[System.ServiceModel.ServiceContractAttribute(Namespace="http://ClassLibraryCalculateBMI", ConfigurationName="ICalculateBMI")]
public interface ICalculateBMI
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ClassLibraryCalculateBMI/ICalculateBMI/CalculateBmi", ReplyAction="http://ClassLibraryCalculateBMI/ICalculateBMI/CalculateBmiResponse")]
    double CalculateBmi(double length, double weight);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ClassLibraryCalculateBMI/ICalculateBMI/CalculateBmi", ReplyAction="http://ClassLibraryCalculateBMI/ICalculateBMI/CalculateBmiResponse")]
    System.Threading.Tasks.Task<double> CalculateBmiAsync(double length, double weight);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculateBMIChannel : ICalculateBMI, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculateBMIClient : System.ServiceModel.ClientBase<ICalculateBMI>, ICalculateBMI
{
    
    public CalculateBMIClient()
    {
    }
    
    public CalculateBMIClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculateBMIClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateBMIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateBMIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double CalculateBmi(double length, double weight)
    {
        return base.Channel.CalculateBmi(length, weight);
    }
    
    public System.Threading.Tasks.Task<double> CalculateBmiAsync(double length, double weight)
    {
        return base.Channel.CalculateBmiAsync(length, weight);
    }
}
