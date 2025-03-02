/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ForecastService.Model;
using Amazon.ForecastService.Model.Internal.MarshallTransformations;
using Amazon.ForecastService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ForecastService
{
    /// <summary>
    /// Implementation for accessing ForecastService
    ///
    /// Provides APIs for creating and managing Amazon Forecast resources.
    /// </summary>
    public partial class AmazonForecastServiceClient : AmazonServiceClient, IAmazonForecastService
    {
        private static IServiceMetadata serviceMetadata = new AmazonForecastServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IForecastServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IForecastServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ForecastServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
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
        public AmazonForecastServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
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
        public AmazonForecastServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(AmazonForecastServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonForecastServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonForecastServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials and an
        /// AmazonForecastServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(AWSCredentials credentials, AmazonForecastServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonForecastServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonForecastServiceConfig clientConfig)
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


        #region  CreateAutoPredictor

        /// <summary>
        /// Creates an Amazon Forecast predictor.
        /// 
        ///  
        /// <para>
        /// Amazon Forecast creates predictors with AutoPredictor, which involves applying the
        /// optimal combination of algorithms to each time series in your datasets. You can use
        /// <a>CreateAutoPredictor</a> to create new predictors or upgrade/retrain existing predictors.
        /// </para>
        ///  
        /// <para>
        ///  <b>Creating new predictors</b> 
        /// </para>
        ///  
        /// <para>
        /// The following parameters are required when creating a new predictor:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PredictorName</code> - A unique name for the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The ARN of the dataset group used to train the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ForecastFrequency</code> - The granularity of your forecasts (hourly, daily,
        /// weekly, etc).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ForecastHorizon</code> - The number of time-steps that the model predicts.
        /// The forecast horizon is also called the prediction length.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating a new predictor, do not specify a value for <code>ReferencePredictorArn</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Upgrading and retraining predictors</b> 
        /// </para>
        ///  
        /// <para>
        /// The following parameters are required when retraining or upgrading a predictor:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PredictorName</code> - A unique name for the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReferencePredictorArn</code> - The ARN of the predictor to retrain or upgrade.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When upgrading or retraining a predictor, only specify values for the <code>ReferencePredictorArn</code>
        /// and <code>PredictorName</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoPredictor service method.</param>
        /// 
        /// <returns>The response from the CreateAutoPredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        public virtual CreateAutoPredictorResponse CreateAutoPredictor(CreateAutoPredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoPredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoPredictorResponseUnmarshaller.Instance;

            return Invoke<CreateAutoPredictorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoPredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoPredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        public virtual IAsyncResult BeginCreateAutoPredictor(CreateAutoPredictorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoPredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoPredictorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoPredictor.</param>
        /// 
        /// <returns>Returns a  CreateAutoPredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        public virtual CreateAutoPredictorResponse EndCreateAutoPredictor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutoPredictorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataset

        /// <summary>
        /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
        /// helps Forecast understand how to consume the data for model training. This includes
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
        /// data is collected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Domain</code> </i> and <i> <code>DatasetType</code> </i> - Each dataset
        /// has an associated dataset domain and a type within the domain. Amazon Forecast provides
        /// a list of predefined domains and types within each domain. For each unique dataset
        /// domain and type within the domain, Amazon Forecast requires your data to include a
        /// minimum set of predefined fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Schema</code> </i> - A schema specifies the fields in the dataset, including
        /// the field name and data type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After creating a dataset, you import your training data into it and add the dataset
        /// to a dataset group. You use the dataset group to create a predictor. For more information,
        /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Importing
        /// datasets</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasets.html">ListDatasets</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example Forecast datasets, see the <a href="https://github.com/aws-samples/amazon-forecast-samples">Amazon
        /// Forecast Sample GitHub repository</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
        /// training data. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatasetGroup

        /// <summary>
        /// Creates a dataset group, which holds a collection of related datasets. You can add
        /// datasets to the dataset group when you create the dataset group, or later by using
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_UpdateDatasetGroup.html">UpdateDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// After creating a dataset group and adding datasets, you use the dataset group when
        /// you create a predictor. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Dataset
        /// groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets groups, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetGroups.html">ListDatasetGroups</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
        /// can use the dataset group to create a predictor. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDatasetGroup(CreateDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual CreateDatasetGroupResponse EndCreateDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatasetImportJob

        /// <summary>
        /// Imports your training data to an Amazon Forecast dataset. You provide the location
        /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
        /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
        /// 
        ///  
        /// <para>
        /// You must specify a <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DataSource.html">DataSource</a>
        /// object that includes an AWS Identity and Access Management (IAM) role that Amazon
        /// Forecast can assume to access the data, as Amazon Forecast makes a copy of your data
        /// and processes it in an internal AWS system. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/aws-forecast-iam-roles.html">Set
        /// up permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The training data must be in CSV or Parquet format. The delimiter must be a comma
        /// (,).
        /// </para>
        ///  
        /// <para>
        /// You can specify the path to a specific file, the S3 bucket, or to a folder in the
        /// S3 bucket. For the latter two cases, Amazon Forecast imports all files up to the limit
        /// of 10,000 files.
        /// </para>
        ///  
        /// <para>
        /// Because dataset imports are not aggregated, your most recent dataset import is the
        /// one that is used when training a predictor or generating a forecast. Make sure that
        /// your most recent dataset import contains all of the data you want to model off of,
        /// and not just the new data collected since the previous import.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your dataset import jobs, filtered by specified criteria, use
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetImportJobs.html">ListDatasetImportJobs</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateDatasetImportJob(CreateDatasetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual CreateDatasetImportJobResponse EndCreateDatasetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExplainability

        /// <summary>
        /// <note> 
        /// <para>
        /// Explainability is only available for Forecasts and Predictors generated from an AutoPredictor
        /// (<a>CreateAutoPredictor</a>)
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an Amazon Forecast Explainability.
        /// </para>
        ///  
        /// <para>
        /// Explainability helps you better understand how the attributes in your datasets impact
        /// forecast. Amazon Forecast uses a metric called Impact scores to quantify the relative
        /// impact of each attribute and determine whether they increase or decrease forecast
        /// values.
        /// </para>
        ///  
        /// <para>
        /// To enable Forecast Explainability, your predictor must include at least one of the
        /// following: related time series, item metadata, or additional datasets like Holidays
        /// and the Weather Index.
        /// </para>
        ///  
        /// <para>
        /// CreateExplainability accepts either a Predictor ARN or Forecast ARN. To receive aggregated
        /// Impact scores for all time series and time points in your datasets, provide a Predictor
        /// ARN. To receive Impact scores for specific time series and time points, provide a
        /// Forecast ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>CreateExplainability with a Predictor ARN</b> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only have one Explainability resource per predictor. If you already enabled
        /// <code>ExplainPredictor</code> in <a>CreateAutoPredictor</a>, that predictor already
        /// has an Explainability resource.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following parameters are required when providing a Predictor ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceArn</code> - The Arn of the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimePointGranularity</code> - Must be set to “ALL”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimeSeriesGranularity</code> - Must be set to “ALL”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Do not specify a value for the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DataSource</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Schema</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StartDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EndDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>CreateExplainability with a Forecast ARN</b> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify a maximum of 50 time series and 500 time points.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following parameters are required when providing a Predictor ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceArn</code> - The Arn of the forecast.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimePointGranularity</code> - Either “ALL” or “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimeSeriesGranularity</code> - Either “ALL” or “SPECIFIC”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set TimeSeriesGranularity to “SPECIFIC”, you must also provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DataSource</code> - The S3 location of the CSV file specifying your time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Schema</code> - The Schema defines the attributes and attribute types listed
        /// in the Data Source.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set TimePointGranularity to “SPECIFIC”, you must also provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>StartDateTime</code> - The first timestamp in the range of time points.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EndDateTime</code> - The last timestamp in the range of time points.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainability service method.</param>
        /// 
        /// <returns>The response from the CreateExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        public virtual CreateExplainabilityResponse CreateExplainability(CreateExplainabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExplainabilityResponseUnmarshaller.Instance;

            return Invoke<CreateExplainabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        public virtual IAsyncResult BeginCreateExplainability(CreateExplainabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExplainabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExplainability.</param>
        /// 
        /// <returns>Returns a  CreateExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        public virtual CreateExplainabilityResponse EndCreateExplainability(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExplainabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExplainabilityExport

        /// <summary>
        /// Exports an Explainability resource created by the <a>CreateExplainability</a> operation.
        /// Exported files are exported to an Amazon Simple Storage Service (Amazon S3) bucket.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Amazon S3 bucket
        /// and an AWS Identity and Access Management (IAM) role that Amazon Forecast can assume
        /// to access the Amazon S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the export job must be <code>ACTIVE</code> before you can
        /// access the export in your Amazon S3 bucket. To get the status, use the <a>DescribeExplainabilityExport</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the CreateExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        public virtual CreateExplainabilityExportResponse CreateExplainabilityExport(CreateExplainabilityExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExplainabilityExportResponseUnmarshaller.Instance;

            return Invoke<CreateExplainabilityExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        public virtual IAsyncResult BeginCreateExplainabilityExport(CreateExplainabilityExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExplainabilityExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  CreateExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        public virtual CreateExplainabilityExportResponse EndCreateExplainabilityExport(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExplainabilityExportResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateForecast

        /// <summary>
        /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
        /// was used to train the predictor. This is known as inference. To retrieve the forecast
        /// for a single item at low latency, use the operation. To export the complete forecast
        /// into your Amazon Simple Storage Service (Amazon S3) bucket, use the <a>CreateForecastExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// The range of the forecast is determined by the <code>ForecastHorizon</code> value,
        /// which you specify in the <a>CreatePredictor</a> request. When you query a forecast,
        /// you can request a specific date range within the forecast.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same time zone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
        /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
        /// status.
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, a forecast includes predictions for every item (<code>item_id</code>)
        /// in the dataset group that was used to train the predictor. However, you can use the
        /// <code>TimeSeriesSelector</code> object to generate a forecast on a subset of time
        /// series. Forecast creation is skipped for any time series that you specify that are
        /// not in the input dataset. The forecast export file will not contain these time series
        /// or their forecasted values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast service method.</param>
        /// 
        /// <returns>The response from the CreateForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        public virtual CreateForecastResponse CreateForecast(CreateForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastResponseUnmarshaller.Instance;

            return Invoke<CreateForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        public virtual IAsyncResult BeginCreateForecast(CreateForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecast.</param>
        /// 
        /// <returns>Returns a  CreateForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        public virtual CreateForecastResponse EndCreateForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateForecastExportJob

        /// <summary>
        /// Exports a forecast created by the <a>CreateForecast</a> operation to your Amazon Simple
        /// Storage Service (Amazon S3) bucket. The forecast file name will match the following
        /// conventions:
        /// 
        ///  
        /// <para>
        /// &lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;
        /// </para>
        ///  
        /// <para>
        /// where the &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an AWS Identity and
        /// Access Management (IAM) role that Amazon Forecast can assume to access the Amazon
        /// S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecast export jobs, use the <a>ListForecastExportJobs</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeForecastExportJob</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        public virtual CreateForecastExportJobResponse CreateForecastExportJob(CreateForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateForecastExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateForecastExportJob(CreateForecastExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecastExportJob.</param>
        /// 
        /// <returns>Returns a  CreateForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        public virtual CreateForecastExportJobResponse EndCreateForecastExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateForecastExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMonitor

        /// <summary>
        /// Creates a predictor monitor resource for an existing auto predictor. Predictor monitoring
        /// allows you to see how your predictor's performance changes over time. For more information,
        /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring.html">Predictor
        /// Monitoring</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMonitorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePredictor

        /// <summary>
        /// <note> 
        /// <para>
        ///  This operation creates a legacy predictor that does not include all the predictor
        /// functionalities provided by Amazon Forecast. To create a predictor that is compatible
        /// with all aspects of Forecast, use <a>CreateAutoPredictor</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an Amazon Forecast predictor.
        /// </para>
        ///  
        /// <para>
        /// In the request, provide a dataset group and either specify an algorithm or let Amazon
        /// Forecast choose an algorithm for you using AutoML. If you specify an algorithm, you
        /// also can override algorithm-specific hyperparameters.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast uses the algorithm to train a predictor using the latest version of
        /// the datasets in the specified dataset group. You can then generate a forecast using
        /// the <a>CreateForecast</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// You can specify a featurization configuration to fill and aggregate the data fields
        /// in the <code>TARGET_TIME_SERIES</code> dataset to improve model training. For more
        /// information, see <a>FeaturizationConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For RELATED_TIME_SERIES datasets, <code>CreatePredictor</code> verifies that the <code>DataFrequency</code>
        /// specified when the dataset was created matches the <code>ForecastFrequency</code>.
        /// TARGET_TIME_SERIES datasets don't have this restriction. Amazon Forecast also verifies
        /// the delimiter and timestamp format. For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, predictors are trained and evaluated at the 0.1 (P10), 0.5 (P50), and
        /// 0.9 (P90) quantiles. You can choose custom forecast types to train and evaluate your
        /// predictor by setting the <code>ForecastTypes</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>AutoML</b> 
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon Forecast to evaluate each algorithm and choose the one that minimizes
        /// the <code>objective function</code>, set <code>PerformAutoML</code> to <code>true</code>.
        /// The <code>objective function</code> is defined as the mean of the weighted losses
        /// over the forecast types. By default, these are the p10, p50, and p90 quantile losses.
        /// For more information, see <a>EvaluationResult</a>.
        /// </para>
        ///  
        /// <para>
        /// When AutoML is enabled, the following properties are disallowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HPOConfig</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformHPO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrainingParameters</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of all of your predictors, use the <a>ListPredictors</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can use the predictor to create a forecast, the <code>Status</code> of
        /// the predictor must be <code>ACTIVE</code>, signifying that training has completed.
        /// To get the status, use the <a>DescribePredictor</a> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor service method.</param>
        /// 
        /// <returns>The response from the CreatePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        public virtual CreatePredictorResponse CreatePredictor(CreatePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorResponseUnmarshaller.Instance;

            return Invoke<CreatePredictorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        public virtual IAsyncResult BeginCreatePredictor(CreatePredictorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePredictor.</param>
        /// 
        /// <returns>Returns a  CreatePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        public virtual CreatePredictorResponse EndCreatePredictor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePredictorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePredictorBacktestExportJob

        /// <summary>
        /// Exports backtest forecasts and accuracy metrics generated by the <a>CreateAutoPredictor</a>
        /// or <a>CreatePredictor</a> operations. Two folders containing CSV or Parquet files
        /// are exported to your specified S3 bucket.
        /// 
        ///  
        /// <para>
        ///  The export file names will match the following conventions:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;ExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;.csv</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The &lt;ExportTimestamp&gt; component is in Java SimpleDate format (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Amazon S3 bucket
        /// and an AWS Identity and Access Management (IAM) role that Amazon Forecast can assume
        /// to access the Amazon S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the export job must be <code>ACTIVE</code> before you can
        /// access the export in your Amazon S3 bucket. To get the status, use the <a>DescribePredictorBacktestExportJob</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the CreatePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        public virtual CreatePredictorBacktestExportJobResponse CreatePredictorBacktestExportJob(CreatePredictorBacktestExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return Invoke<CreatePredictorBacktestExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        public virtual IAsyncResult BeginCreatePredictorBacktestExportJob(CreatePredictorBacktestExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  CreatePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        public virtual CreatePredictorBacktestExportJobResponse EndCreatePredictorBacktestExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePredictorBacktestExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWhatIfAnalysis

        /// <summary>
        /// What-if analysis is a scenario modeling technique where you make a hypothetical change
        /// to a time series and compare the forecasts generated by these changes against the
        /// baseline, unchanged time series. It is important to remember that the purpose of a
        /// what-if analysis is to understand how a forecast can change given different modifications
        /// to the baseline time series.
        /// 
        ///  
        /// <para>
        /// For example, imagine you are a clothing retailer who is considering an end of season
        /// sale to clear space for new styles. After creating a baseline forecast, you can use
        /// a what-if analysis to investigate how different sales tactics might affect your goals.
        /// You could create a scenario where everything is given a 25% markdown and another where
        /// everything is given a fixed dollar markdown. You can create a scenario where the sale
        /// lasts for 1 week and another where the sale lasts for 1 month. Your what-if analysis
        /// enables you to compare many different scenarios against each other.
        /// </para>
        ///  
        /// <para>
        /// Note that a what-if analysis is meant to display what the forecasting model has learned
        /// and how it will behave in the scenarios that you are evaluating. Do not blindly use
        /// the results of the what-if analysis to make business decisions. For instance, forecasts
        /// might not be accurate for novel scenarios where there is no reference available to
        /// determine whether a forecast is good.
        /// </para>
        ///  
        /// <para>
        /// The <a>TimeSeriesSelector</a> object defines the items that you want in the what-if
        /// analysis.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        public virtual CreateWhatIfAnalysisResponse CreateWhatIfAnalysis(CreateWhatIfAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfAnalysisResponseUnmarshaller.Instance;

            return Invoke<CreateWhatIfAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        public virtual IAsyncResult BeginCreateWhatIfAnalysis(CreateWhatIfAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        public virtual CreateWhatIfAnalysisResponse EndCreateWhatIfAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWhatIfAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWhatIfForecast

        /// <summary>
        /// A what-if forecast is a forecast that is created from a modified version of the baseline
        /// forecast. Each what-if forecast incorporates either a replacement dataset or a set
        /// of transformations to the original dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        public virtual CreateWhatIfForecastResponse CreateWhatIfForecast(CreateWhatIfForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfForecastResponseUnmarshaller.Instance;

            return Invoke<CreateWhatIfForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        public virtual IAsyncResult BeginCreateWhatIfForecast(CreateWhatIfForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        public virtual CreateWhatIfForecastResponse EndCreateWhatIfForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWhatIfForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWhatIfForecastExport

        /// <summary>
        /// Exports a forecast created by the <a>CreateWhatIfForecast</a> operation to your Amazon
        /// Simple Storage Service (Amazon S3) bucket. The forecast file name will match the following
        /// conventions:
        /// 
        ///  
        /// <para>
        ///  <code>≈&lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an AWS Identity and
        /// Access Management (IAM) role that Amazon Forecast can assume to access the Amazon
        /// S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your what-if forecast export jobs, use the <a>ListWhatIfForecastExports</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        public virtual CreateWhatIfForecastExportResponse CreateWhatIfForecastExport(CreateWhatIfForecastExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfForecastExportResponseUnmarshaller.Instance;

            return Invoke<CreateWhatIfForecastExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        public virtual IAsyncResult BeginCreateWhatIfForecastExport(CreateWhatIfForecastExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatIfForecastExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        public virtual CreateWhatIfForecastExportResponse EndCreateWhatIfForecastExport(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWhatIfForecastExportResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes an Amazon Forecast dataset that was created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation. You can only delete datasets that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Forecast does not automatically update any dataset groups that contain the deleted
        /// dataset. In order to update the dataset group, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_UpdateDatasetGroup.html">UpdateDatasetGroup</a>
        /// operation, omitting the deleted dataset's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatasetGroup

        /// <summary>
        /// Deletes a dataset group created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation. You can only delete dataset groups that have a status of <code>ACTIVE</code>,
        /// <code>CREATE_FAILED</code>, or <code>UPDATE_FAILED</code>. To get the status, use
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This operation deletes only the dataset group, not the datasets in the group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatasetGroup(DeleteDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual DeleteDatasetGroupResponse EndDeleteDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatasetImportJob

        /// <summary>
        /// Deletes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation. You can delete only dataset import jobs that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        public virtual DeleteDatasetImportJobResponse DeleteDatasetImportJob(DeleteDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatasetImportJob(DeleteDatasetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        public virtual DeleteDatasetImportJobResponse EndDeleteDatasetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExplainability

        /// <summary>
        /// Deletes an Explainability resource.
        /// 
        ///  
        /// <para>
        /// You can delete only predictor that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainability service method.</param>
        /// 
        /// <returns>The response from the DeleteExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        public virtual DeleteExplainabilityResponse DeleteExplainability(DeleteExplainabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExplainabilityResponseUnmarshaller.Instance;

            return Invoke<DeleteExplainabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        public virtual IAsyncResult BeginDeleteExplainability(DeleteExplainabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExplainabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExplainability.</param>
        /// 
        /// <returns>Returns a  DeleteExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        public virtual DeleteExplainabilityResponse EndDeleteExplainability(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExplainabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExplainabilityExport

        /// <summary>
        /// Deletes an Explainability export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the DeleteExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        public virtual DeleteExplainabilityExportResponse DeleteExplainabilityExport(DeleteExplainabilityExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExplainabilityExportResponseUnmarshaller.Instance;

            return Invoke<DeleteExplainabilityExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        public virtual IAsyncResult BeginDeleteExplainabilityExport(DeleteExplainabilityExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExplainabilityExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  DeleteExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        public virtual DeleteExplainabilityExportResponse EndDeleteExplainabilityExport(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExplainabilityExportResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteForecast

        /// <summary>
        /// Deletes a forecast created using the <a>CreateForecast</a> operation. You can delete
        /// only forecasts that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// You can't delete a forecast while it is being exported. After a forecast is deleted,
        /// you can no longer query the forecast.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast service method.</param>
        /// 
        /// <returns>The response from the DeleteForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        public virtual DeleteForecastResponse DeleteForecast(DeleteForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastResponseUnmarshaller.Instance;

            return Invoke<DeleteForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        public virtual IAsyncResult BeginDeleteForecast(DeleteForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecast.</param>
        /// 
        /// <returns>Returns a  DeleteForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        public virtual DeleteForecastResponse EndDeleteForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteForecastExportJob

        /// <summary>
        /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// You can delete only export jobs that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeForecastExportJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        public virtual DeleteForecastExportJobResponse DeleteForecastExportJob(DeleteForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteForecastExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteForecastExportJob(DeleteForecastExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DeleteForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        public virtual DeleteForecastExportJobResponse EndDeleteForecastExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteForecastExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMonitor

        /// <summary>
        /// Deletes a monitor resource. You can only delete a monitor resource with a status of
        /// <code>ACTIVE</code>, <code>ACTIVE_STOPPED</code>, <code>CREATE_FAILED</code>, or <code>CREATE_STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMonitorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePredictor

        /// <summary>
        /// Deletes a predictor created using the <a>DescribePredictor</a> or <a>CreatePredictor</a>
        /// operations. You can delete only predictor that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribePredictor</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor service method.</param>
        /// 
        /// <returns>The response from the DeletePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        public virtual DeletePredictorResponse DeletePredictor(DeletePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorResponseUnmarshaller.Instance;

            return Invoke<DeletePredictorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        public virtual IAsyncResult BeginDeletePredictor(DeletePredictorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePredictor.</param>
        /// 
        /// <returns>Returns a  DeletePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        public virtual DeletePredictorResponse EndDeletePredictor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePredictorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePredictorBacktestExportJob

        /// <summary>
        /// Deletes a predictor backtest export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the DeletePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        public virtual DeletePredictorBacktestExportJobResponse DeletePredictorBacktestExportJob(DeletePredictorBacktestExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return Invoke<DeletePredictorBacktestExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        public virtual IAsyncResult BeginDeletePredictorBacktestExportJob(DeletePredictorBacktestExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  DeletePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        public virtual DeletePredictorBacktestExportJobResponse EndDeletePredictorBacktestExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePredictorBacktestExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceTree

        /// <summary>
        /// Deletes an entire resource tree. This operation will delete the parent resource and
        /// its child resources.
        /// 
        ///  
        /// <para>
        /// Child resources are resources that were created from another resource. For example,
        /// when a forecast is generated from a predictor, the forecast is the child resource
        /// and the predictor is the parent resource.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast resources possess the following parent-child resource hierarchies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Dataset</b>: dataset import jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dataset Group</b>: predictors, predictor backtest export jobs, forecasts, forecast
        /// export jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Predictor</b>: predictor backtest export jobs, forecasts, forecast export jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Forecast</b>: forecast export jobs
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <code>DeleteResourceTree</code> will only delete Amazon Forecast resources, and will
        /// not delete datasets or exported files stored in Amazon S3. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceTree service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceTree service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        public virtual DeleteResourceTreeResponse DeleteResourceTree(DeleteResourceTreeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceTreeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceTreeResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceTreeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceTree operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceTree operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceTree
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceTree(DeleteResourceTreeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceTreeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceTreeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceTree operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceTree.</param>
        /// 
        /// <returns>Returns a  DeleteResourceTreeResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        public virtual DeleteResourceTreeResponse EndDeleteResourceTree(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceTreeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWhatIfAnalysis

        /// <summary>
        /// Deletes a what-if analysis created using the <a>CreateWhatIfAnalysis</a> operation.
        /// You can delete only what-if analyses that have a status of <code>ACTIVE</code> or
        /// <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfAnalysis</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// You can't delete a what-if analysis while any of its forecasts are being exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        public virtual DeleteWhatIfAnalysisResponse DeleteWhatIfAnalysis(DeleteWhatIfAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfAnalysisResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatIfAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        public virtual IAsyncResult BeginDeleteWhatIfAnalysis(DeleteWhatIfAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        public virtual DeleteWhatIfAnalysisResponse EndDeleteWhatIfAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWhatIfAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWhatIfForecast

        /// <summary>
        /// Deletes a what-if forecast created using the <a>CreateWhatIfForecast</a> operation.
        /// You can delete only what-if forecasts that have a status of <code>ACTIVE</code> or
        /// <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfForecast</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// You can't delete a what-if forecast while it is being exported. After a what-if forecast
        /// is deleted, you can no longer query the what-if analysis.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        public virtual DeleteWhatIfForecastResponse DeleteWhatIfForecast(DeleteWhatIfForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfForecastResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatIfForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        public virtual IAsyncResult BeginDeleteWhatIfForecast(DeleteWhatIfForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        public virtual DeleteWhatIfForecastResponse EndDeleteWhatIfForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWhatIfForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWhatIfForecastExport

        /// <summary>
        /// Deletes a what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
        /// operation. You can delete only what-if forecast exports that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        public virtual DeleteWhatIfForecastExportResponse DeleteWhatIfForecastExport(DeleteWhatIfForecastExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfForecastExportResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatIfForecastExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        public virtual IAsyncResult BeginDeleteWhatIfForecastExport(DeleteWhatIfForecastExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatIfForecastExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        public virtual DeleteWhatIfForecastExportResponse EndDeleteWhatIfForecastExport(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWhatIfForecastExportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutoPredictor

        /// <summary>
        /// Describes a predictor created using the CreateAutoPredictor operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoPredictor service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoPredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        public virtual DescribeAutoPredictorResponse DescribeAutoPredictor(DescribeAutoPredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoPredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoPredictorResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoPredictorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoPredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoPredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutoPredictor(DescribeAutoPredictorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoPredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoPredictorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoPredictor.</param>
        /// 
        /// <returns>Returns a  DescribeAutoPredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        public virtual DescribeAutoPredictorResponse EndDescribeAutoPredictor(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoPredictorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Describes an Amazon Forecast dataset created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters specified in the <code>CreateDataset</code>
        /// request, this operation includes the following dataset properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDatasetGroup

        /// <summary>
        /// Describes a dataset group created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters provided in the <code>CreateDatasetGroup</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetArns</code> - The datasets belonging to the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeDatasetGroup(DescribeDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual DescribeDatasetGroupResponse EndDescribeDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDatasetImportJob

        /// <summary>
        /// Describes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters provided in the <code>CreateDatasetImportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldStatistics</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDatasetImportJob(DescribeDatasetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual DescribeDatasetImportJobResponse EndDescribeDatasetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExplainability

        /// <summary>
        /// Describes an Explainability resource created using the <a>CreateExplainability</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainability service method.</param>
        /// 
        /// <returns>The response from the DescribeExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        public virtual DescribeExplainabilityResponse DescribeExplainability(DescribeExplainabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExplainabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeExplainabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        public virtual IAsyncResult BeginDescribeExplainability(DescribeExplainabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExplainabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExplainabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExplainability.</param>
        /// 
        /// <returns>Returns a  DescribeExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        public virtual DescribeExplainabilityResponse EndDescribeExplainability(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExplainabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExplainabilityExport

        /// <summary>
        /// Describes an Explainability export created using the <a>CreateExplainabilityExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the DescribeExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        public virtual DescribeExplainabilityExportResponse DescribeExplainabilityExport(DescribeExplainabilityExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExplainabilityExportResponseUnmarshaller.Instance;

            return Invoke<DescribeExplainabilityExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        public virtual IAsyncResult BeginDescribeExplainabilityExport(DescribeExplainabilityExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExplainabilityExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExplainabilityExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  DescribeExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        public virtual DescribeExplainabilityExportResponse EndDescribeExplainabilityExport(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExplainabilityExportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeForecast

        /// <summary>
        /// Describes a forecast created using the <a>CreateForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateForecast</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The dataset group that provided the training data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast service method.</param>
        /// 
        /// <returns>The response from the DescribeForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        public virtual DescribeForecastResponse DescribeForecast(DescribeForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastResponseUnmarshaller.Instance;

            return Invoke<DescribeForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        public virtual IAsyncResult BeginDescribeForecast(DescribeForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecast.</param>
        /// 
        /// <returns>Returns a  DescribeForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        public virtual DescribeForecastResponse EndDescribeForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeForecastExportJob

        /// <summary>
        /// Describes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecastExportJob</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        public virtual DescribeForecastExportJobResponse DescribeForecastExportJob(DescribeForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeForecastExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeForecastExportJob(DescribeForecastExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        public virtual DescribeForecastExportJobResponse EndDescribeForecastExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeForecastExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMonitor

        /// <summary>
        /// Describes a monitor resource. In addition to listing the properties provided in the
        /// <a>CreateMonitor</a> request, this operation lists the following properties:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Baseline</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastEvaluationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastEvaluationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitor service method.</param>
        /// 
        /// <returns>The response from the DescribeMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        public virtual DescribeMonitorResponse DescribeMonitor(DescribeMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitorResponseUnmarshaller.Instance;

            return Invoke<DescribeMonitorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        public virtual IAsyncResult BeginDescribeMonitor(DescribeMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMonitor.</param>
        /// 
        /// <returns>Returns a  DescribeMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        public virtual DescribeMonitorResponse EndDescribeMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMonitorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePredictor

        /// <summary>
        /// <note> 
        /// <para>
        ///  This operation is only valid for legacy predictors created with CreatePredictor.
        /// If you are not using a legacy predictor, use <a>DescribeAutoPredictor</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Describes a predictor created using the <a>CreatePredictor</a> operation.
        /// </para>
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreatePredictor</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetImportJobArns</code> - The dataset import jobs used to import training
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutoMLAlgorithmArns</code> - If AutoML is performed, the algorithms that were
        /// evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor service method.</param>
        /// 
        /// <returns>The response from the DescribePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        public virtual DescribePredictorResponse DescribePredictor(DescribePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorResponseUnmarshaller.Instance;

            return Invoke<DescribePredictorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        public virtual IAsyncResult BeginDescribePredictor(DescribePredictorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePredictor.</param>
        /// 
        /// <returns>Returns a  DescribePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        public virtual DescribePredictorResponse EndDescribePredictor(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePredictorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePredictorBacktestExportJob

        /// <summary>
        /// Describes a predictor backtest export job created using the <a>CreatePredictorBacktestExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreatePredictorBacktestExportJob</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> (if an error occurred)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        public virtual DescribePredictorBacktestExportJobResponse DescribePredictorBacktestExportJob(DescribePredictorBacktestExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribePredictorBacktestExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribePredictorBacktestExportJob(DescribePredictorBacktestExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorBacktestExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorBacktestExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  DescribePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        public virtual DescribePredictorBacktestExportJobResponse EndDescribePredictorBacktestExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePredictorBacktestExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWhatIfAnalysis

        /// <summary>
        /// Describes the what-if analysis created using the <a>CreateWhatIfAnalysis</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfAnalysis</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        public virtual DescribeWhatIfAnalysisResponse DescribeWhatIfAnalysis(DescribeWhatIfAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfAnalysisResponseUnmarshaller.Instance;

            return Invoke<DescribeWhatIfAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        public virtual IAsyncResult BeginDescribeWhatIfAnalysis(DescribeWhatIfAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        public virtual DescribeWhatIfAnalysisResponse EndDescribeWhatIfAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWhatIfAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWhatIfForecast

        /// <summary>
        /// Describes the what-if forecast created using the <a>CreateWhatIfForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfForecast</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        public virtual DescribeWhatIfForecastResponse DescribeWhatIfForecast(DescribeWhatIfForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfForecastResponseUnmarshaller.Instance;

            return Invoke<DescribeWhatIfForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        public virtual IAsyncResult BeginDescribeWhatIfForecast(DescribeWhatIfForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        public virtual DescribeWhatIfForecastResponse EndDescribeWhatIfForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWhatIfForecastResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWhatIfForecastExport

        /// <summary>
        /// Describes the what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfForecastExport</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        public virtual DescribeWhatIfForecastExportResponse DescribeWhatIfForecastExport(DescribeWhatIfForecastExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfForecastExportResponseUnmarshaller.Instance;

            return Invoke<DescribeWhatIfForecastExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        public virtual IAsyncResult BeginDescribeWhatIfForecastExport(DescribeWhatIfForecastExportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWhatIfForecastExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWhatIfForecastExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        public virtual DescribeWhatIfForecastExportResponse EndDescribeWhatIfForecastExport(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWhatIfForecastExportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccuracyMetrics

        /// <summary>
        /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
        /// operation. Use metrics to see how well the model performed and to decide whether to
        /// use the predictor to generate a forecast. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/metrics.html">Predictor
        /// Metrics</a>.
        /// 
        ///  
        /// <para>
        /// This operation generates metrics for each backtest window that was evaluated. The
        /// number of backtest windows (<code>NumberOfBacktestWindows</code>) is specified using
        /// the <a>EvaluationParameters</a> object, which is optionally included in the <code>CreatePredictor</code>
        /// request. If <code>NumberOfBacktestWindows</code> isn't specified, the number defaults
        /// to one.
        /// </para>
        ///  
        /// <para>
        /// The parameters of the <code>filling</code> method determine which items contribute
        /// to the metrics. If you want all items to contribute, specify <code>zero</code>. If
        /// you want only those items that have complete data in the range being evaluated to
        /// contribute, specify <code>nan</code>. For more information, see <a>FeaturizationMethod</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can get accuracy metrics, the <code>Status</code> of the predictor must
        /// be <code>ACTIVE</code>, signifying that training has completed. To get the status,
        /// use the <a>DescribePredictor</a> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics service method.</param>
        /// 
        /// <returns>The response from the GetAccuracyMetrics service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        public virtual GetAccuracyMetricsResponse GetAccuracyMetrics(GetAccuracyMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccuracyMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccuracyMetricsResponseUnmarshaller.Instance;

            return Invoke<GetAccuracyMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccuracyMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetAccuracyMetrics(GetAccuracyMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccuracyMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccuracyMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccuracyMetrics.</param>
        /// 
        /// <returns>Returns a  GetAccuracyMetricsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        public virtual GetAccuracyMetricsResponse EndGetAccuracyMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccuracyMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasetGroups

        /// <summary>
        /// Returns a list of dataset groups created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation. For each dataset group, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the dataset group ARN with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual IAsyncResult BeginListDatasetGroups(ListDatasetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetGroups.</param>
        /// 
        /// <returns>Returns a  ListDatasetGroupsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual ListDatasetGroupsResponse EndListDatasetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasetImportJobs

        /// <summary>
        /// Returns a list of dataset import jobs created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation. For each import job, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the ARN with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// operation. You can filter the list by providing an array of <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_Filter.html">Filter</a>
        /// objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListDatasetImportJobs(ListDatasetImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetImportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual ListDatasetImportJobsResponse EndListDatasetImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Returns a list of datasets created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation. For each dataset, a summary of its properties, including its Amazon Resource
        /// Name (ARN), is returned. To retrieve the complete set of properties, use the ARN with
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExplainabilities

        /// <summary>
        /// Returns a list of Explainability resources created using the <a>CreateExplainability</a>
        /// operation. This operation returns a summary for each Explainability. You can filter
        /// the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular Explainability resource,
        /// use the ARN with the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilities service method.</param>
        /// 
        /// <returns>The response from the ListExplainabilities service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        public virtual ListExplainabilitiesResponse ListExplainabilities(ListExplainabilitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExplainabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExplainabilitiesResponseUnmarshaller.Instance;

            return Invoke<ListExplainabilitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExplainabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilities operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExplainabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        public virtual IAsyncResult BeginListExplainabilities(ListExplainabilitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExplainabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExplainabilitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExplainabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExplainabilities.</param>
        /// 
        /// <returns>Returns a  ListExplainabilitiesResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        public virtual ListExplainabilitiesResponse EndListExplainabilities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExplainabilitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExplainabilityExports

        /// <summary>
        /// Returns a list of Explainability exports created using the <a>CreateExplainabilityExport</a>
        /// operation. This operation returns a summary for each Explainability export. You can
        /// filter the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular Explainability export,
        /// use the ARN with the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilityExports service method.</param>
        /// 
        /// <returns>The response from the ListExplainabilityExports service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        public virtual ListExplainabilityExportsResponse ListExplainabilityExports(ListExplainabilityExportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExplainabilityExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExplainabilityExportsResponseUnmarshaller.Instance;

            return Invoke<ListExplainabilityExportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExplainabilityExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilityExports operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExplainabilityExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        public virtual IAsyncResult BeginListExplainabilityExports(ListExplainabilityExportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExplainabilityExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExplainabilityExportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExplainabilityExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExplainabilityExports.</param>
        /// 
        /// <returns>Returns a  ListExplainabilityExportsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        public virtual ListExplainabilityExportsResponse EndListExplainabilityExports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExplainabilityExportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListForecastExportJobs

        /// <summary>
        /// Returns a list of forecast export jobs created using the <a>CreateForecastExportJob</a>
        /// operation. For each forecast export job, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). To retrieve the complete set of properties,
        /// use the ARN with the <a>DescribeForecastExportJob</a> operation. You can filter the
        /// list using an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListForecastExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        public virtual ListForecastExportJobsResponse ListForecastExportJobs(ListForecastExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListForecastExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecastExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        public virtual IAsyncResult BeginListForecastExportJobs(ListForecastExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecastExportJobs.</param>
        /// 
        /// <returns>Returns a  ListForecastExportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        public virtual ListForecastExportJobsResponse EndListForecastExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListForecastExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListForecasts

        /// <summary>
        /// Returns a list of forecasts created using the <a>CreateForecast</a> operation. For
        /// each forecast, this operation returns a summary of its properties, including its Amazon
        /// Resource Name (ARN). To retrieve the complete set of properties, specify the ARN with
        /// the <a>DescribeForecast</a> operation. You can filter the list using an array of <a>Filter</a>
        /// objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts service method.</param>
        /// 
        /// <returns>The response from the ListForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        public virtual ListForecastsResponse ListForecasts(ListForecastsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastsResponseUnmarshaller.Instance;

            return Invoke<ListForecastsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecasts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        public virtual IAsyncResult BeginListForecasts(ListForecastsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecasts.</param>
        /// 
        /// <returns>Returns a  ListForecastsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        public virtual ListForecastsResponse EndListForecasts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListForecastsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMonitorEvaluations

        /// <summary>
        /// Returns a list of the monitoring evaluation results and predictor events collected
        /// by the monitor resource during different windows of time.
        /// 
        ///  
        /// <para>
        /// For information about monitoring see <a>predictor-monitoring</a>. For more information
        /// about retrieving monitoring results see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring-results.html">Viewing
        /// Monitoring Results</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitorEvaluations service method.</param>
        /// 
        /// <returns>The response from the ListMonitorEvaluations service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        public virtual ListMonitorEvaluationsResponse ListMonitorEvaluations(ListMonitorEvaluationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitorEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorEvaluationsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorEvaluationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitorEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitorEvaluations operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitorEvaluations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        public virtual IAsyncResult BeginListMonitorEvaluations(ListMonitorEvaluationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitorEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorEvaluationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitorEvaluations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitorEvaluations.</param>
        /// 
        /// <returns>Returns a  ListMonitorEvaluationsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        public virtual ListMonitorEvaluationsResponse EndListMonitorEvaluations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMonitorEvaluationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMonitors

        /// <summary>
        /// Returns a list of monitors created with the <a>CreateMonitor</a> operation and <a>CreateAutoPredictor</a>
        /// operation. For each monitor resource, this operation returns of a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve a complete set of properties
        /// of a monitor resource by specify the monitor's ARN in the <a>DescribeMonitor</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMonitorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPredictorBacktestExportJobs

        /// <summary>
        /// Returns a list of predictor backtest export jobs created using the <a>CreatePredictorBacktestExportJob</a>
        /// operation. This operation returns a summary for each backtest export job. You can
        /// filter the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular backtest export job, use
        /// the ARN with the <a>DescribePredictorBacktestExportJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictorBacktestExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListPredictorBacktestExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        public virtual ListPredictorBacktestExportJobsResponse ListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorBacktestExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorBacktestExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListPredictorBacktestExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPredictorBacktestExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPredictorBacktestExportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPredictorBacktestExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        public virtual IAsyncResult BeginListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorBacktestExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorBacktestExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPredictorBacktestExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPredictorBacktestExportJobs.</param>
        /// 
        /// <returns>Returns a  ListPredictorBacktestExportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        public virtual ListPredictorBacktestExportJobsResponse EndListPredictorBacktestExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPredictorBacktestExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPredictors

        /// <summary>
        /// Returns a list of predictors created using the <a>CreateAutoPredictor</a> or <a>CreatePredictor</a>
        /// operations. For each predictor, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// You can retrieve the complete set of properties by using the ARN with the <a>DescribeAutoPredictor</a>
        /// and <a>DescribePredictor</a> operations. You can filter the list using an array of
        /// <a>Filter</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors service method.</param>
        /// 
        /// <returns>The response from the ListPredictors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        public virtual ListPredictorsResponse ListPredictors(ListPredictorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorsResponseUnmarshaller.Instance;

            return Invoke<ListPredictorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPredictors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        public virtual IAsyncResult BeginListPredictors(ListPredictorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPredictors.</param>
        /// 
        /// <returns>Returns a  ListPredictorsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        public virtual ListPredictorsResponse EndListPredictors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPredictorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for an Amazon Forecast resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWhatIfAnalyses

        /// <summary>
        /// Returns a list of what-if analyses created using the <a>CreateWhatIfAnalysis</a> operation.
        /// For each what-if analysis, this operation returns a summary of its properties, including
        /// its Amazon Resource Name (ARN). You can retrieve the complete set of properties by
        /// using the what-if analysis ARN with the <a>DescribeWhatIfAnalysis</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfAnalyses service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfAnalyses service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        public virtual ListWhatIfAnalysesResponse ListWhatIfAnalyses(ListWhatIfAnalysesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfAnalysesResponseUnmarshaller.Instance;

            return Invoke<ListWhatIfAnalysesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfAnalyses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfAnalyses operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfAnalyses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        public virtual IAsyncResult BeginListWhatIfAnalyses(ListWhatIfAnalysesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfAnalysesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfAnalyses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfAnalyses.</param>
        /// 
        /// <returns>Returns a  ListWhatIfAnalysesResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        public virtual ListWhatIfAnalysesResponse EndListWhatIfAnalyses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWhatIfAnalysesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWhatIfForecastExports

        /// <summary>
        /// Returns a list of what-if forecast exports created using the <a>CreateWhatIfForecastExport</a>
        /// operation. For each what-if forecast export, this operation returns a summary of its
        /// properties, including its Amazon Resource Name (ARN). You can retrieve the complete
        /// set of properties by using the what-if forecast export ARN with the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecastExports service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfForecastExports service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        public virtual ListWhatIfForecastExportsResponse ListWhatIfForecastExports(ListWhatIfForecastExportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfForecastExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfForecastExportsResponseUnmarshaller.Instance;

            return Invoke<ListWhatIfForecastExportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfForecastExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecastExports operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfForecastExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        public virtual IAsyncResult BeginListWhatIfForecastExports(ListWhatIfForecastExportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfForecastExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfForecastExportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfForecastExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfForecastExports.</param>
        /// 
        /// <returns>Returns a  ListWhatIfForecastExportsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        public virtual ListWhatIfForecastExportsResponse EndListWhatIfForecastExports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWhatIfForecastExportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWhatIfForecasts

        /// <summary>
        /// Returns a list of what-if forecasts created using the <a>CreateWhatIfForecast</a>
        /// operation. For each what-if forecast, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the what-if forecast ARN with the <a>DescribeWhatIfForecast</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecasts service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        public virtual ListWhatIfForecastsResponse ListWhatIfForecasts(ListWhatIfForecastsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfForecastsResponseUnmarshaller.Instance;

            return Invoke<ListWhatIfForecastsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfForecasts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecasts operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfForecasts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        public virtual IAsyncResult BeginListWhatIfForecasts(ListWhatIfForecastsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWhatIfForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatIfForecastsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfForecasts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfForecasts.</param>
        /// 
        /// <returns>Returns a  ListWhatIfForecastsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        public virtual ListWhatIfForecastsResponse EndListWhatIfForecasts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWhatIfForecastsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeResource

        /// <summary>
        /// Resumes a stopped monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeResource service method.</param>
        /// 
        /// <returns>The response from the ResumeResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        public virtual ResumeResourceResponse ResumeResource(ResumeResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeResourceResponseUnmarshaller.Instance;

            return Invoke<ResumeResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        public virtual IAsyncResult BeginResumeResource(ResumeResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeResource.</param>
        /// 
        /// <returns>Returns a  ResumeResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        public virtual ResumeResourceResponse EndResumeResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StopResource

        /// <summary>
        /// Stops a resource.
        /// 
        ///  
        /// <para>
        /// The resource undergoes the following states: <code>CREATE_STOPPING</code> and <code>CREATE_STOPPED</code>.
        /// You cannot resume a resource once it has been stopped.
        /// </para>
        ///  
        /// <para>
        /// This operation can be applied to the following resources (and their corresponding
        /// child resources):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Dataset Import Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Predictor Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Forecast Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Forecast Export Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Predictor Backtest Export Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Explainability Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Explainability Export Job
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopResource service method.</param>
        /// 
        /// <returns>The response from the StopResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        public virtual StopResourceResponse StopResource(StopResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopResourceResponseUnmarshaller.Instance;

            return Invoke<StopResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        public virtual IAsyncResult BeginStopResource(StopResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopResource.</param>
        /// 
        /// <returns>Returns a  StopResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        public virtual StopResourceResponse EndStopResource(IAsyncResult asyncResult)
        {
            return EndInvoke<StopResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDatasetGroup

        /// <summary>
        /// Replaces the datasets in a dataset group with the specified datasets.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the dataset group must be <code>ACTIVE</code> before you
        /// can use the dataset group to create a predictor. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        public virtual UpdateDatasetGroupResponse UpdateDatasetGroup(UpdateDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateDatasetGroup(UpdateDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        public virtual UpdateDatasetGroupResponse EndUpdateDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}