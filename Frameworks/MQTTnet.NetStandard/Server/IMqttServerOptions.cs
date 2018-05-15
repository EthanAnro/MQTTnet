﻿using System;

namespace MQTTnet.Server
{
    public interface IMqttServerOptions
    {
        int ConnectionBacklog { get; }

        bool EnablePersistentSessions { get; }

        int MaxPendingMessagesPerClient { get; }
        MqttPendingMessagesOverflowStrategy PendingMessagesOverflowStrategy { get; }

        TimeSpan DefaultCommunicationTimeout { get; }

        Action<MqttConnectionValidatorContext> ConnectionValidator { get; }
        Action<MqttSubscriptionInterceptorContext> SubscriptionInterceptor { get; }
        Action<MqttApplicationMessageInterceptorContext> ApplicationMessageInterceptor { get; }

        MqttServerDefaultEndpointOptions DefaultEndpointOptions { get; }
        MqttServerTlsEndpointOptions TlsEndpointOptions { get; }

        IMqttServerStorage Storage { get; }
    }
}