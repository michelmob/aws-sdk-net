/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.EKS.Model;
using Amazon.EKS.Model.Internal.MarshallTransformations;
using Amazon.EKS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EKS
{
    /// <summary>
    /// Implementation for accessing EKS
    ///
    /// Amazon Elastic Kubernetes Service (Amazon EKS) is a managed service that makes it
    /// easy for you to run Kubernetes on AWS without needing to stand up or maintain your
    /// own Kubernetes control plane. Kubernetes is an open-source system for automating the
    /// deployment, scaling, and management of containerized applications. 
    /// 
    ///  
    /// <para>
    /// Amazon EKS runs up-to-date versions of the open-source Kubernetes software, so you
    /// can use all the existing plugins and tooling from the Kubernetes community. Applications
    /// running on Amazon EKS are fully compatible with applications running on any standard
    /// Kubernetes environment, whether running in on-premises data centers or public clouds.
    /// This means that you can easily migrate any standard Kubernetes application to Amazon
    /// EKS without any code modification required.
    /// </para>
    /// </summary>
    public partial class AmazonEKSClient : AmazonServiceClient, IAmazonEKS
    {
        private static IServiceMetadata serviceMetadata = new AmazonEKSMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEKSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEKSConfig()) { }

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEKSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(AmazonEKSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEKSClient(AWSCredentials credentials)
            : this(credentials, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEKSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials and an
        /// AmazonEKSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(AWSCredentials credentials, AmazonEKSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEKSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEKSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateCluster

        /// <summary>
        /// Creates an Amazon EKS control plane. 
        /// 
        ///  
        /// <para>
        /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
        /// software, such as <code>etcd</code> and the API server. The control plane runs in
        /// an account managed by AWS, and the Kubernetes API is exposed via the Amazon EKS API
        /// server endpoint. Each Amazon EKS cluster control plane is single-tenant and unique
        /// and runs on its own set of Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// The cluster control plane is provisioned across multiple Availability Zones and fronted
        /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
        /// network interfaces in your VPC subnets to provide connectivity from the control plane
        /// instances to the worker nodes (for example, to support <code>kubectl exec</code>,
        /// <code>logs</code>, and <code>proxy</code> data flows).
        /// </para>
        ///  
        /// <para>
        /// Amazon EKS worker nodes run in your AWS account and connect to your cluster's control
        /// plane via the Kubernetes API server endpoint and a certificate file that is created
        /// for your cluster.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>endpointPublicAccess</code> and <code>endpointPrivateAccess</code>
        /// parameters to enable or disable public and private access to your cluster's Kubernetes
        /// API server endpoint. By default, public access is enabled, and private access is disabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>logging</code> parameter to enable or disable exporting the
        /// Kubernetes control plane logs for your cluster to CloudWatch Logs. By default, cluster
        /// control plane logs aren't exported to CloudWatch Logs. For more information, see <a
        /// href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cluster creation typically takes between 10 and 15 minutes. After you create an Amazon
        /// EKS cluster, you must configure your Kubernetes tooling to communicate with the API
        /// server and launch worker nodes into your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managing-auth.html">Managing
        /// Cluster Authentication</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
        /// Amazon EKS Worker Nodes</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.UnsupportedAvailabilityZoneException">
        /// At least one of your specified cluster subnets is in an Availability Zone that does
        /// not support Amazon EKS. The exception output specifies the supported Availability
        /// Zones for your account, from which you can choose subnets for your cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Deletes the Amazon EKS cluster control plane. 
        /// 
        ///  <note> 
        /// <para>
        /// If you have active services in your cluster that are associated with a load balancer,
        /// you must delete those services before deleting the cluster so that the load balancers
        /// are deleted properly. Otherwise, you can have orphaned resources in your VPC that
        /// prevent you from being able to delete the VPC. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/delete-cluster.html">Deleting
        /// a Cluster</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Returns descriptive information about an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// The API server endpoint and certificate authority data returned by this operation
        /// are required for <code>kubelet</code> and <code>kubectl</code> to communicate with
        /// your Kubernetes API server. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Create
        /// a kubeconfig for Amazon EKS</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The API server endpoint and certificate authority data aren't available until the
        /// cluster reaches the <code>ACTIVE</code> state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUpdate

        /// <summary>
        /// Returns descriptive information about an update against your Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// When the status of the update is <code>Succeeded</code>, the update is complete. If
        /// an update fails, the status is <code>Failed</code>, and an error detail explains the
        /// reason for the failure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdate service method.</param>
        /// 
        /// <returns>The response from the DescribeUpdate service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual DescribeUpdateResponse DescribeUpdate(DescribeUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return Invoke<DescribeUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdate operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual IAsyncResult BeginDescribeUpdate(DescribeUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUpdate.</param>
        /// 
        /// <returns>Returns a  DescribeUpdateResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual DescribeUpdateResponse EndDescribeUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Lists the Amazon EKS clusters in your AWS account in the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for an Amazon EKS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUpdates

        /// <summary>
        /// Lists the updates associated with an Amazon EKS cluster in your AWS account, in the
        /// specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUpdates service method.</param>
        /// 
        /// <returns>The response from the ListUpdates service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual ListUpdatesResponse ListUpdates(ListUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListUpdatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUpdates operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual IAsyncResult BeginListUpdates(ListUpdatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUpdates.</param>
        /// 
        /// <returns>Returns a  ListUpdatesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual ListUpdatesResponse EndListUpdates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUpdatesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterConfig

        /// <summary>
        /// Updates an Amazon EKS cluster configuration. Your cluster continues to function during
        /// the update. The response output includes an update ID that you can use to track the
        /// status of your cluster update with the <a>DescribeUpdate</a> API operation.
        /// 
        ///  
        /// <para>
        /// You can use this API operation to enable or disable exporting the Kubernetes control
        /// plane logs for your cluster to CloudWatch Logs. By default, cluster control plane
        /// logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use this API operation to enable or disable public and private access
        /// to your cluster's Kubernetes API server endpoint. By default, public access is enabled,
        /// and private access is disabled. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// At this time, you can not update the subnets or security group IDs for an existing
        /// cluster.
        /// </para>
        ///  </important> 
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <code>UPDATING</code> (this status transition
        /// is eventually consistent). When the update is complete (either <code>Failed</code>
        /// or <code>Successful</code>), the cluster status moves to <code>Active</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual UpdateClusterConfigResponse UpdateClusterConfig(UpdateClusterConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterConfig(UpdateClusterConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterConfig.</param>
        /// 
        /// <returns>Returns a  UpdateClusterConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual UpdateClusterConfigResponse EndUpdateClusterConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterVersion

        /// <summary>
        /// Updates an Amazon EKS cluster to the specified Kubernetes version. Your cluster continues
        /// to function during the update. The response output includes an update ID that you
        /// can use to track the status of your cluster update with the <a>DescribeUpdate</a>
        /// API operation.
        /// 
        ///  
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <code>UPDATING</code> (this status transition
        /// is eventually consistent). When the update is complete (either <code>Failed</code>
        /// or <code>Successful</code>), the cluster status moves to <code>Active</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterVersion service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual UpdateClusterVersionResponse UpdateClusterVersion(UpdateClusterVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterVersion operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterVersion(UpdateClusterVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterVersion.</param>
        /// 
        /// <returns>Returns a  UpdateClusterVersionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual UpdateClusterVersionResponse EndUpdateClusterVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterVersionResponse>(asyncResult);
        }

        #endregion
        
    }
}