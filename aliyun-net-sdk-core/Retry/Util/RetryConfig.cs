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

namespace Aliyun.Acs.Core.Retry.Util
{
    internal static class RetryConfig
    {
        private static void initData()
        {
            products = new Dictionary<string, Product>() { };
            Product productEcs = new Product();
            productEcs.ProductName = "ecs";
            Version version20140526 = new Version();
            version20140526.VersionDate = "2014-05-26";
            version20140526.RetryableAPIs.Add("DescribeAccessPoints");
            version20140526.RetryableAPIs.Add("DescribeAccountAttributes");
            version20140526.RetryableAPIs.Add("DescribeAutoSnapshotPolicyEx");
            version20140526.RetryableAPIs.Add("DescribeAvailableResource");
            version20140526.RetryableAPIs.Add("DescribeBandwidthLimitation");
            version20140526.RetryableAPIs.Add("DescribeBandwidthPackages");
            version20140526.RetryableAPIs.Add("DescribeClassicLinkInstances");
            version20140526.RetryableAPIs.Add("DescribeCloudAssistantStatus");
            version20140526.RetryableAPIs.Add("DescribeClusters");
            version20140526.RetryableAPIs.Add("DescribeCommands");
            version20140526.RetryableAPIs.Add("DescribeDedicatedHostAutoRenew");
            version20140526.RetryableAPIs.Add("DescribeDedicatedHosts");
            version20140526.RetryableAPIs.Add("DescribeDedicatedHostTypes");
            version20140526.RetryableAPIs.Add("DescribeDeploymentSets");
            version20140526.RetryableAPIs.Add("DescribeDiskMonitorData");
            version20140526.RetryableAPIs.Add("DescribeDisks");
            version20140526.RetryableAPIs.Add("DescribeDisksFullStatus");
            version20140526.RetryableAPIs.Add("DescribeEipAddresses");
            version20140526.RetryableAPIs.Add("DescribeEipMonitorData");
            version20140526.RetryableAPIs.Add("DescribeEniMonitorData");
            version20140526.RetryableAPIs.Add("DescribeForwardTableEntries");
            version20140526.RetryableAPIs.Add("DescribeHaVips");
            version20140526.RetryableAPIs.Add("DescribeHpcClusters");
            version20140526.RetryableAPIs.Add("DescribeImages");
            version20140526.RetryableAPIs.Add("DescribeImageSharePermission");
            version20140526.RetryableAPIs.Add("DescribeImageSupportInstanceTypes");
            version20140526.RetryableAPIs.Add("DescribeInstanceAttribute");
            version20140526.RetryableAPIs.Add("DescribeInstanceAutoRenewAttribute");
            version20140526.RetryableAPIs.Add("DescribeInstanceHistoryEvents");
            version20140526.RetryableAPIs.Add("DescribeInstanceMonitorData");
            version20140526.RetryableAPIs.Add("DescribeInstancePhysicalAttribute");
            version20140526.RetryableAPIs.Add("DescribeInstanceRamRole");
            version20140526.RetryableAPIs.Add("DescribeInstances");
            version20140526.RetryableAPIs.Add("DescribeInstancesFullStatus");
            version20140526.RetryableAPIs.Add("DescribeInstanceStatus");
            version20140526.RetryableAPIs.Add("DescribeInstanceTopology");
            version20140526.RetryableAPIs.Add("DescribeInstanceTypeFamilies");
            version20140526.RetryableAPIs.Add("DescribeInstanceTypes");
            version20140526.RetryableAPIs.Add("DescribeInstanceVncPasswd");
            version20140526.RetryableAPIs.Add("DescribeInstanceVncUrl");
            version20140526.RetryableAPIs.Add("DescribeInvocationResults");
            version20140526.RetryableAPIs.Add("DescribeInvocations");
            version20140526.RetryableAPIs.Add("DescribeKeyPairs");
            version20140526.RetryableAPIs.Add("DescribeLaunchTemplates");
            version20140526.RetryableAPIs.Add("DescribeLaunchTemplateVersions");
            version20140526.RetryableAPIs.Add("DescribeLimitation");
            version20140526.RetryableAPIs.Add("DescribeNatGateways");
            version20140526.RetryableAPIs.Add("DescribeNetworkInterfacePermissions");
            version20140526.RetryableAPIs.Add("DescribeNetworkInterfaces");
            version20140526.RetryableAPIs.Add("DescribeNewProjectEipMonitorData");
            version20140526.RetryableAPIs.Add("DescribePhysicalConnections");
            version20140526.RetryableAPIs.Add("DescribePrice");
            version20140526.RetryableAPIs.Add("DescribeRecommendInstanceType");
            version20140526.RetryableAPIs.Add("DescribeRegions");
            version20140526.RetryableAPIs.Add("DescribeRenewalPrice");
            version20140526.RetryableAPIs.Add("DescribeResourceByTags");
            version20140526.RetryableAPIs.Add("DescribeResourcesModification");
            version20140526.RetryableAPIs.Add("DescribeRouterInterfaces");
            version20140526.RetryableAPIs.Add("DescribeRouteTables");
            version20140526.RetryableAPIs.Add("DescribeSecurityGroupAttribute");
            version20140526.RetryableAPIs.Add("DescribeSecurityGroupReferences");
            version20140526.RetryableAPIs.Add("DescribeSecurityGroups");
            version20140526.RetryableAPIs.Add("DescribeSnapshotLinks");
            version20140526.RetryableAPIs.Add("DescribeSnapshotMonitorData");
            version20140526.RetryableAPIs.Add("DescribeSnapshotPackage");
            version20140526.RetryableAPIs.Add("DescribeSnapshots");
            version20140526.RetryableAPIs.Add("DescribeSnapshotsUsage");
            version20140526.RetryableAPIs.Add("DescribeSpotPriceHistory");
            version20140526.RetryableAPIs.Add("DescribeTags");
            version20140526.RetryableAPIs.Add("DescribeTaskAttribute");
            version20140526.RetryableAPIs.Add("DescribeTasks");
            version20140526.RetryableAPIs.Add("DescribeUserBusinessBehavior");
            version20140526.RetryableAPIs.Add("DescribeUserData");
            version20140526.RetryableAPIs.Add("DescribeVirtualBorderRouters");
            version20140526.RetryableAPIs.Add("DescribeVirtualBorderRoutersForPhysicalConnection");
            version20140526.RetryableAPIs.Add("DescribeVpcs");
            version20140526.RetryableAPIs.Add("DescribeVRouters");
            version20140526.RetryableAPIs.Add("DescribeVSwitches");
            version20140526.RetryableAPIs.Add("DescribeZones");
            version20140526.RetryableAPIsWithClientToken.Add("CreateDisk");
            version20140526.RetryableAPIsWithClientToken.Add("CreateImage");
            version20140526.RetryableAPIsWithClientToken.Add("CreateInstance");
            version20140526.RetryableAPIsWithClientToken.Add("CreateNetworkInterface");
            version20140526.RetryableAPIsWithClientToken.Add("CreateSnapshot");
            version20140526.RetryableAPIsWithClientToken.Add("ModifyDiskChargeType");
            version20140526.RetryableAPIsWithClientToken.Add("ModifyInstanceChargeType");
            version20140526.RetryableAPIsWithClientToken.Add("ModifyInstanceNetworkSpec");
            version20140526.RetryableAPIsWithClientToken.Add("ModifyInstanceSpec");
            version20140526.RetryableAPIsWithClientToken.Add("ModifyPrepayInstanceSpec");
            version20140526.RetryableAPIsWithClientToken.Add("RenewInstance");
            version20140526.RetryableAPIsWithClientToken.Add("ReplaceSystemDisk");
            version20140526.RetryableAPIsWithClientToken.Add("ResizeDisk");
            version20140526.RetryableAPIsWithClientToken.Add("RunInstances");
            version20140526.RetryableThrottlingErrors.Add("Throttling");
            version20140526.RetryableNormalErrors.Add("InternalError");
            version20140526.RetryableNormalErrors.Add("UnknownError");
            version20140526.RetryableNormalErrors.Add("ServiceUnavailable");
            productEcs.versions.Add("2014-05-26", version20140526);
            
            products.Add("ecs", productEcs);
        }

        private static Dictionary<string, Product> products;

        public static List<string> Get(string productName, string versionDate, string sectionName)
        {
            if (products == null)
            {
                initData();
            }
            List<string> apis = new List<string>() { };
            if (products.ContainsKey(productName))
            {
                Product product = products[productName];
                if (product.versions.ContainsKey(versionDate))
                {
                    Version version = product.versions[versionDate];
                    switch (sectionName)
                    {
                        case "RetryableAPIs":
                            apis = version.RetryableAPIs;
                            break;
                        case "RetryableAPIsWithClientToken":
                            apis = version.RetryableAPIsWithClientToken;
                            break;
                        case "RetryableThrottlingErrors":
                            apis = version.RetryableThrottlingErrors;
                            break;
                        case "RetryableNormalErrors":
                            apis = version.RetryableNormalErrors;
                            break;
                    }
                    return apis;
                }
            }
            return apis;
        }
    }

    public class Product
    {
        public string ProductName { get; set; }

        public Dictionary<string, Version> versions = new Dictionary<string, Version>(){};
    }

    public class Version
    {
        public String VersionDate { get; set; }

        public List<string> RetryableAPIs = new List<string>(){};

        public List<string> RetryableAPIsWithClientToken = new List<string>(){};

        public List<string> RetryableThrottlingErrors = new List<string>(){};

        public List<string> RetryableNormalErrors = new List<string>(){};
    }
}
