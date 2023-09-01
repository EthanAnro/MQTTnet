using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet.Protocol;

namespace MQTTnet.Extensions.Rpc
{
    public interface IMqttRpcClient : IDisposable
    {
        Task<byte[]> ExecuteAsync(TimeSpan timeout, string methodName, byte[] payload, MqttQualityOfServiceLevel qualityOfServiceLevel, IDictionary<string,object> parameters = null);
        
        Task<byte[]> ExecuteAsync(string methodName, byte[] payload, MqttQualityOfServiceLevel qualityOfServiceLevel, IDictionary<string, object> parameters = null, CancellationToken cancellationToken = default);
    }
}