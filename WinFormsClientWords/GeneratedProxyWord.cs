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
[System.ServiceModel.ServiceContractAttribute(Namespace="http://ClassLibraryHobby", ConfigurationName="IWordClass")]
public interface IWordClass
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ClassLibraryHobby/IWordClass/GetNumberOfWords", ReplyAction="http://ClassLibraryHobby/IWordClass/GetNumberOfWordsResponse")]
    int GetNumberOfWords(string sentence);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ClassLibraryHobby/IWordClass/GetNumberOfWords", ReplyAction="http://ClassLibraryHobby/IWordClass/GetNumberOfWordsResponse")]
    System.Threading.Tasks.Task<int> GetNumberOfWordsAsync(string sentence);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IWordClassChannel : IWordClass, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class WordClassClient : System.ServiceModel.ClientBase<IWordClass>, IWordClass
{
    
    public WordClassClient()
    {
    }
    
    public WordClassClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WordClassClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WordClassClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WordClassClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int GetNumberOfWords(string sentence)
    {
        return base.Channel.GetNumberOfWords(sentence);
    }
    
    public System.Threading.Tasks.Task<int> GetNumberOfWordsAsync(string sentence)
    {
        return base.Channel.GetNumberOfWordsAsync(sentence);
    }
}
