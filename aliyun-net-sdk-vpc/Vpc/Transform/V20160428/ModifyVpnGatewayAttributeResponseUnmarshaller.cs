/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ModifyVpnGatewayAttributeResponseUnmarshaller
    {
        public static ModifyVpnGatewayAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyVpnGatewayAttributeResponse modifyVpnGatewayAttributeResponse = new ModifyVpnGatewayAttributeResponse();

			modifyVpnGatewayAttributeResponse.HttpResponse = context.HttpResponse;
			modifyVpnGatewayAttributeResponse.RequestId = context.StringValue("ModifyVpnGatewayAttribute.RequestId");
			modifyVpnGatewayAttributeResponse.VpnGatewayId = context.StringValue("ModifyVpnGatewayAttribute.VpnGatewayId");
			modifyVpnGatewayAttributeResponse.VpcId = context.StringValue("ModifyVpnGatewayAttribute.VpcId");
			modifyVpnGatewayAttributeResponse.VSwitchId = context.StringValue("ModifyVpnGatewayAttribute.VSwitchId");
			modifyVpnGatewayAttributeResponse.InternetIp = context.StringValue("ModifyVpnGatewayAttribute.InternetIp");
			modifyVpnGatewayAttributeResponse.IntranetIp = context.StringValue("ModifyVpnGatewayAttribute.IntranetIp");
			modifyVpnGatewayAttributeResponse.CreateTime = context.LongValue("ModifyVpnGatewayAttribute.CreateTime");
			modifyVpnGatewayAttributeResponse.EndTime = context.LongValue("ModifyVpnGatewayAttribute.EndTime");
			modifyVpnGatewayAttributeResponse.Spec = context.StringValue("ModifyVpnGatewayAttribute.Spec");
			modifyVpnGatewayAttributeResponse.Name = context.StringValue("ModifyVpnGatewayAttribute.Name");
			modifyVpnGatewayAttributeResponse.Description = context.StringValue("ModifyVpnGatewayAttribute.Description");
			modifyVpnGatewayAttributeResponse.Status = context.StringValue("ModifyVpnGatewayAttribute.Status");
			modifyVpnGatewayAttributeResponse.BusinessStatus = context.StringValue("ModifyVpnGatewayAttribute.BusinessStatus");
        
			return modifyVpnGatewayAttributeResponse;
        }
    }
}
