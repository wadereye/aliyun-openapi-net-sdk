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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ListBriefConfigByActionRequest : RpcAcsRequest<ListBriefConfigByActionResponse>
    {
        public ListBriefConfigByActionRequest()
            : base("cloudwf", "2017-03-28", "ListBriefConfigByAction", "cloudwf", "openAPI")
        {
        }

		private long? ancestorApgroupId;

		private int? limit;

		private string action;

		private string fuzzySearch;

		private string accessKeyId;

		public long? AncestorApgroupId
		{
			get
			{
				return ancestorApgroupId;
			}
			set	
			{
				ancestorApgroupId = value;
				DictionaryUtil.Add(QueryParameters, "AncestorApgroupId", value.ToString());
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string FuzzySearch
		{
			get
			{
				return fuzzySearch;
			}
			set	
			{
				fuzzySearch = value;
				DictionaryUtil.Add(QueryParameters, "FuzzySearch", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ListBriefConfigByActionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListBriefConfigByActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
