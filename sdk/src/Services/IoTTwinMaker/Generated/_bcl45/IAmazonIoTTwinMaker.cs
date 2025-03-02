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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTTwinMaker.Model;

namespace Amazon.IoTTwinMaker
{
    /// <summary>
    /// Interface for accessing IoTTwinMaker
    ///
    /// IoT TwinMaker is a service that enables you to build operational digital twins of
    /// physical systems. IoT TwinMaker overlays measurements and analysis from real-world
    /// sensors, cameras, and enterprise applications so you can create data visualizations
    /// to monitor your physical factory, building, or industrial plant. You can use this
    /// real-world data to monitor operations and diagnose and repair errors.
    /// </summary>
    public partial interface IAmazonIoTTwinMaker : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTTwinMakerPaginatorFactory Paginators { get; }

        
        #region  BatchPutPropertyValues


        /// <summary>
        /// Sets values for multiple time series properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues service method.</param>
        /// 
        /// <returns>The response from the BatchPutPropertyValues service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        BatchPutPropertyValuesResponse BatchPutPropertyValues(BatchPutPropertyValuesRequest request);



        /// <summary>
        /// Sets values for multiple time series properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutPropertyValues service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        Task<BatchPutPropertyValuesResponse> BatchPutPropertyValuesAsync(BatchPutPropertyValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateComponentType


        /// <summary>
        /// Creates a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType service method.</param>
        /// 
        /// <returns>The response from the CreateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        CreateComponentTypeResponse CreateComponentType(CreateComponentTypeRequest request);



        /// <summary>
        /// Creates a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        Task<CreateComponentTypeResponse> CreateComponentTypeAsync(CreateComponentTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEntity


        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity service method.</param>
        /// 
        /// <returns>The response from the CreateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        CreateEntityResponse CreateEntity(CreateEntityRequest request);



        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        Task<CreateEntityResponse> CreateEntityAsync(CreateEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScene


        /// <summary>
        /// Creates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScene service method.</param>
        /// 
        /// <returns>The response from the CreateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        CreateSceneResponse CreateScene(CreateSceneRequest request);



        /// <summary>
        /// Creates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a workplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request);



        /// <summary>
        /// Creates a workplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteComponentType


        /// <summary>
        /// Deletes a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType service method.</param>
        /// 
        /// <returns>The response from the DeleteComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        DeleteComponentTypeResponse DeleteComponentType(DeleteComponentTypeRequest request);



        /// <summary>
        /// Deletes a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        Task<DeleteComponentTypeResponse> DeleteComponentTypeAsync(DeleteComponentTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEntity


        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity service method.</param>
        /// 
        /// <returns>The response from the DeleteEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        DeleteEntityResponse DeleteEntity(DeleteEntityRequest request);



        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        Task<DeleteEntityResponse> DeleteEntityAsync(DeleteEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScene


        /// <summary>
        /// Deletes a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene service method.</param>
        /// 
        /// <returns>The response from the DeleteScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        DeleteSceneResponse DeleteScene(DeleteSceneRequest request);



        /// <summary>
        /// Deletes a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        Task<DeleteSceneResponse> DeleteSceneAsync(DeleteSceneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request);



        /// <summary>
        /// Deletes a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComponentType


        /// <summary>
        /// Retrieves information about a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType service method.</param>
        /// 
        /// <returns>The response from the GetComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        GetComponentTypeResponse GetComponentType(GetComponentTypeRequest request);



        /// <summary>
        /// Retrieves information about a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        Task<GetComponentTypeResponse> GetComponentTypeAsync(GetComponentTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEntity


        /// <summary>
        /// Retrieves information about an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntity service method.</param>
        /// 
        /// <returns>The response from the GetEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        GetEntityResponse GetEntity(GetEntityRequest request);



        /// <summary>
        /// Retrieves information about an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        Task<GetEntityResponse> GetEntityAsync(GetEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPropertyValue


        /// <summary>
        /// Gets the property values for a component, component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
        /// <code>entityId</code>, or <code>workspaceId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValue service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        GetPropertyValueResponse GetPropertyValue(GetPropertyValueRequest request);



        /// <summary>
        /// Gets the property values for a component, component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
        /// <code>entityId</code>, or <code>workspaceId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertyValue service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        Task<GetPropertyValueResponse> GetPropertyValueAsync(GetPropertyValueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPropertyValueHistory


        /// <summary>
        /// Retrieves information about the history of a time series property value for a component,
        /// component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for <code>workspaceId</code>. For entity-specific queries,
        /// specify values for <code>componentName</code> and <code>entityId</code>. For cross-entity
        /// quries, specify a value for <code>componentTypeId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValueHistory service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        GetPropertyValueHistoryResponse GetPropertyValueHistory(GetPropertyValueHistoryRequest request);



        /// <summary>
        /// Retrieves information about the history of a time series property value for a component,
        /// component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for <code>workspaceId</code>. For entity-specific queries,
        /// specify values for <code>componentName</code> and <code>entityId</code>. For cross-entity
        /// quries, specify a value for <code>componentTypeId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertyValueHistory service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        Task<GetPropertyValueHistoryResponse> GetPropertyValueHistoryAsync(GetPropertyValueHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetScene


        /// <summary>
        /// Retrieves information about a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScene service method.</param>
        /// 
        /// <returns>The response from the GetScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        GetSceneResponse GetScene(GetSceneRequest request);



        /// <summary>
        /// Retrieves information about a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        Task<GetSceneResponse> GetSceneAsync(GetSceneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkspace


        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace service method.</param>
        /// 
        /// <returns>The response from the GetWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request);



        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        Task<GetWorkspaceResponse> GetWorkspaceAsync(GetWorkspaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComponentTypes


        /// <summary>
        /// Lists all component types in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes service method.</param>
        /// 
        /// <returns>The response from the ListComponentTypes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        ListComponentTypesResponse ListComponentTypes(ListComponentTypesRequest request);



        /// <summary>
        /// Lists all component types in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponentTypes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        Task<ListComponentTypesResponse> ListComponentTypesAsync(ListComponentTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEntities


        /// <summary>
        /// Lists all entities in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse ListEntities(ListEntitiesRequest request);



        /// <summary>
        /// Lists all entities in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScenes


        /// <summary>
        /// Lists all scenes in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScenes service method.</param>
        /// 
        /// <returns>The response from the ListScenes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        ListScenesResponse ListScenes(ListScenesRequest request);



        /// <summary>
        /// Lists all scenes in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScenes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScenes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Retrieves information about workspaces in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request);



        /// <summary>
        /// Retrieves information about workspaces in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.TooManyTagsException">
        /// The number of tags exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.TooManyTagsException">
        /// The number of tags exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateComponentType


        /// <summary>
        /// Updates information in a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        UpdateComponentTypeResponse UpdateComponentType(UpdateComponentTypeRequest request);



        /// <summary>
        /// Updates information in a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        Task<UpdateComponentTypeResponse> UpdateComponentTypeAsync(UpdateComponentTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEntity


        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity service method.</param>
        /// 
        /// <returns>The response from the UpdateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        UpdateEntityResponse UpdateEntity(UpdateEntityRequest request);



        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        Task<UpdateEntityResponse> UpdateEntityAsync(UpdateEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateScene


        /// <summary>
        /// Updates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene service method.</param>
        /// 
        /// <returns>The response from the UpdateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        UpdateSceneResponse UpdateScene(UpdateSceneRequest request);



        /// <summary>
        /// Updates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        Task<UpdateSceneResponse> UpdateSceneAsync(UpdateSceneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorkspace


        /// <summary>
        /// Updates a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request);



        /// <summary>
        /// Updates a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}