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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IotData.Model;
using Amazon.IotData.Model.Internal.MarshallTransformations;
using Amazon.IotData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IotData
{
    /// <summary>
    /// Implementation for accessing IotData
    ///
    /// IoT data 
    /// <para>
    /// IoT data enables secure, bi-directional communication between Internet-connected things
    /// (such as sensors, actuators, embedded devices, or smart appliances) and the Amazon
    /// Web Services cloud. It implements a broker for applications and things to publish
    /// messages over HTTP (Publish) and retrieve, update, and delete shadows. A shadow is
    /// a persistent representation of your things and their state in the Amazon Web Services
    /// cloud.
    /// </para>
    ///  
    /// <para>
    /// Find the endpoint address for actions in IoT data by running this CLI command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws iot describe-endpoint --endpoint-type iot:Data-ATS</code> 
    /// </para>
    ///  
    /// <para>
    /// The service name used by <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Amazon
    /// Web ServicesSignature Version 4</a> to sign requests is: <i>iotdevicegateway</i>.
    /// </para>
    /// </summary>
    public partial class AmazonIotDataClient : AmazonServiceClient, IAmazonIotData
    {
        private static IServiceMetadata serviceMetadata = new AmazonIotDataMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIotDataPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIotDataPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IotDataPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  DeleteThingShadow

        /// <summary>
        /// Deletes the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteThingShadow</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_DeleteThingShadow.html">DeleteThingShadow</a>
        /// in the IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow service method.</param>
        /// 
        /// <returns>The response from the DeleteThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        public virtual DeleteThingShadowResponse DeleteThingShadow(DeleteThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingShadowResponseUnmarshaller.Instance;

            return Invoke<DeleteThingShadowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        public virtual IAsyncResult BeginDeleteThingShadow(DeleteThingShadowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingShadowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThingShadow.</param>
        /// 
        /// <returns>Returns a  DeleteThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        public virtual DeleteThingShadowResponse EndDeleteThingShadow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteThingShadowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRetainedMessage

        /// <summary>
        /// Gets the details of a single retained message for the specified topic.
        /// 
        ///  
        /// <para>
        /// This action returns the message payload of the retained message, which can incur messaging
        /// costs. To list only the topic names of the retained messages, call <a href="/iot/latest/developerguide/API_iotdata_ListRetainedMessages.html">ListRetainedMessages</a>.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiotfleethubfordevicemanagement.html#awsiotfleethubfordevicemanagement-actions-as-permissions">GetRetainedMessage</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
        /// Web Services IoT Core pricing - Messaging</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetainedMessage service method.</param>
        /// 
        /// <returns>The response from the GetRetainedMessage service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetRetainedMessage">REST API Reference for GetRetainedMessage Operation</seealso>
        public virtual GetRetainedMessageResponse GetRetainedMessage(GetRetainedMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetainedMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetainedMessageResponseUnmarshaller.Instance;

            return Invoke<GetRetainedMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetainedMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetainedMessage operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetainedMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetRetainedMessage">REST API Reference for GetRetainedMessage Operation</seealso>
        public virtual IAsyncResult BeginGetRetainedMessage(GetRetainedMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetainedMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetainedMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetainedMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetainedMessage.</param>
        /// 
        /// <returns>Returns a  GetRetainedMessageResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetRetainedMessage">REST API Reference for GetRetainedMessage Operation</seealso>
        public virtual GetRetainedMessageResponse EndGetRetainedMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRetainedMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetThingShadow

        /// <summary>
        /// Gets the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetThingShadow</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_GetThingShadow.html">GetThingShadow</a>
        /// in the IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow service method.</param>
        /// 
        /// <returns>The response from the GetThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        public virtual GetThingShadowResponse GetThingShadow(GetThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingShadowResponseUnmarshaller.Instance;

            return Invoke<GetThingShadowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        public virtual IAsyncResult BeginGetThingShadow(GetThingShadowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingShadowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThingShadow.</param>
        /// 
        /// <returns>Returns a  GetThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        public virtual GetThingShadowResponse EndGetThingShadow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetThingShadowResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNamedShadowsForThing

        /// <summary>
        /// Lists the shadows for the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListNamedShadowsForThing</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedShadowsForThing service method.</param>
        /// 
        /// <returns>The response from the ListNamedShadowsForThing service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        public virtual ListNamedShadowsForThingResponse ListNamedShadowsForThing(ListNamedShadowsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedShadowsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedShadowsForThingResponseUnmarshaller.Instance;

            return Invoke<ListNamedShadowsForThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamedShadowsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamedShadowsForThing operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamedShadowsForThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        public virtual IAsyncResult BeginListNamedShadowsForThing(ListNamedShadowsForThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedShadowsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedShadowsForThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamedShadowsForThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamedShadowsForThing.</param>
        /// 
        /// <returns>Returns a  ListNamedShadowsForThingResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        public virtual ListNamedShadowsForThingResponse EndListNamedShadowsForThing(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNamedShadowsForThingResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRetainedMessages

        /// <summary>
        /// Lists summary information about the retained messages stored for the account.
        /// 
        ///  
        /// <para>
        /// This action returns only the topic names of the retained messages. It doesn't return
        /// any message payloads. Although this action doesn't return a message payload, it can
        /// still incur messaging costs.
        /// </para>
        ///  
        /// <para>
        /// To get the message payload of a retained message, call <a href="https://docs.aws.amazon.com/iot/latest/developerguide/API_iotdata_GetRetainedMessage.html">GetRetainedMessage</a>
        /// with the topic name of the retained message.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiotfleethubfordevicemanagement.html#awsiotfleethubfordevicemanagement-actions-as-permissions">ListRetainedMessages</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
        /// Web Services IoT Core pricing - Messaging</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetainedMessages service method.</param>
        /// 
        /// <returns>The response from the ListRetainedMessages service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListRetainedMessages">REST API Reference for ListRetainedMessages Operation</seealso>
        public virtual ListRetainedMessagesResponse ListRetainedMessages(ListRetainedMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetainedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetainedMessagesResponseUnmarshaller.Instance;

            return Invoke<ListRetainedMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetainedMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetainedMessages operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRetainedMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListRetainedMessages">REST API Reference for ListRetainedMessages Operation</seealso>
        public virtual IAsyncResult BeginListRetainedMessages(ListRetainedMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetainedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetainedMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRetainedMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRetainedMessages.</param>
        /// 
        /// <returns>Returns a  ListRetainedMessagesResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListRetainedMessages">REST API Reference for ListRetainedMessages Operation</seealso>
        public virtual ListRetainedMessagesResponse EndListRetainedMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRetainedMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  Publish

        /// <summary>
        /// Publishes an MQTT message.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">Publish</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about MQTT messages, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">MQTT
        /// Protocol</a> in the IoT Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
        /// Web Services IoT Core pricing - Messaging</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        public virtual PublishResponse Publish(PublishRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return Invoke<PublishResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        public virtual IAsyncResult BeginPublish(PublishRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Publish operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a  PublishResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        public virtual PublishResponse EndPublish(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateThingShadow

        /// <summary>
        /// Updates the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThingShadow</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_UpdateThingShadow.html">UpdateThingShadow</a>
        /// in the IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow service method.</param>
        /// 
        /// <returns>The response from the UpdateThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.ConflictException">
        /// The specified version does not match the version of the document.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.RequestEntityTooLargeException">
        /// The payload exceeds the maximum size allowed.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        public virtual UpdateThingShadowResponse UpdateThingShadow(UpdateThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingShadowResponseUnmarshaller.Instance;

            return Invoke<UpdateThingShadowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        public virtual IAsyncResult BeginUpdateThingShadow(UpdateThingShadowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingShadowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThingShadow.</param>
        /// 
        /// <returns>Returns a  UpdateThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        public virtual UpdateThingShadowResponse EndUpdateThingShadow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateThingShadowResponse>(asyncResult);
        }

        #endregion
        
    }
}