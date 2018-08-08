﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;


namespace Apache.NMS.AMQP.Message.Cloak
{
    /// <summary>
    /// Provider specific Cloak Interface from provider implementation.
    /// </summary>
    interface IMessageCloak : IMessage
    {
        byte[] Content
        {
            get;
            set;
        }

        bool IsBodyReadOnly { get; set; }

        bool IsPropertiesReadOnly { get; set; }

        bool IsReceived { get; }

        IMessageCloak Copy();

        object GetMessageAnnotation(string symbolKey);

        void SetMessageAnnotation(string symbolKey, object value);

        object GetDeliveryAnnotation(string symbolKey);

        void SetDeliveryAnnotation(string symbolKey, object value);

        int DeliveryCount { get; set; }

        int RedeliveryCount { get; set; }

        MessageAcknowledgementHandler AckHandler { get; set; }
        
    }
}
