/*
 * Maritimum
 *
 * a sample API to return ships and ports information.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using MaritimumClient.Client;
using MaritimumClient.Model;

namespace MaritimumClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all ports in DB
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Port&gt;</returns>
        List<Port> PortsIndex();

        /// <summary>
        /// Get all ports in DB
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Port&gt;</returns>
        ApiResponse<List<Port>> PortsIndexWithHttpInfo();
        /// <summary>
        /// Get a list of ports using their country and deep water flag
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <returns>List&lt;Port&gt;</returns>
        List<Port> PortsReport(PortReportRequest portReportRequest);

        /// <summary>
        /// Get a list of ports using their country and deep water flag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <returns>ApiResponse of List&lt;Port&gt;</returns>
        ApiResponse<List<Port>> PortsReportWithHttpInfo(PortReportRequest portReportRequest);
        /// <summary>
        /// Get a port by its UUID
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <returns>Port</returns>
        Port PortsShow(Guid body);

        /// <summary>
        /// Get a port by its UUID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <returns>ApiResponse of Port</returns>
        ApiResponse<Port> PortsShowWithHttpInfo(Guid body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all ports in DB
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Port&gt;</returns>
        System.Threading.Tasks.Task<List<Port>> PortsIndexAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all ports in DB
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Port&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Port>>> PortsIndexWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a list of ports using their country and deep water flag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Port&gt;</returns>
        System.Threading.Tasks.Task<List<Port>> PortsReportAsync(PortReportRequest portReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of ports using their country and deep water flag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Port&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Port>>> PortsReportWithHttpInfoAsync(PortReportRequest portReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a port by its UUID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Port</returns>
        System.Threading.Tasks.Task<Port> PortsShowAsync(Guid body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a port by its UUID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Port)</returns>
        System.Threading.Tasks.Task<ApiResponse<Port>> PortsShowWithHttpInfoAsync(Guid body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortApi : IPortApiSync, IPortApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PortApi : IPortApi
    {
        private MaritimumClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortApi(string basePath)
        {
            this.Configuration = MaritimumClient.Client.Configuration.MergeConfigurations(
                MaritimumClient.Client.GlobalConfiguration.Instance,
                new MaritimumClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new MaritimumClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MaritimumClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = MaritimumClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PortApi(MaritimumClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = MaritimumClient.Client.Configuration.MergeConfigurations(
                MaritimumClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new MaritimumClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MaritimumClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = MaritimumClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PortApi(MaritimumClient.Client.ISynchronousClient client, MaritimumClient.Client.IAsynchronousClient asyncClient, MaritimumClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = MaritimumClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public MaritimumClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public MaritimumClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MaritimumClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MaritimumClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get all ports in DB 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Port&gt;</returns>
        public List<Port> PortsIndex()
        {
            MaritimumClient.Client.ApiResponse<List<Port>> localVarResponse = PortsIndexWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all ports in DB 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Port&gt;</returns>
        public MaritimumClient.Client.ApiResponse<List<Port>> PortsIndexWithHttpInfo()
        {
            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Port>>("/port/index", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all ports in DB 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Port&gt;</returns>
        public async System.Threading.Tasks.Task<List<Port>> PortsIndexAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MaritimumClient.Client.ApiResponse<List<Port>> localVarResponse = await PortsIndexWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all ports in DB 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Port&gt;)</returns>
        public async System.Threading.Tasks.Task<MaritimumClient.Client.ApiResponse<List<Port>>> PortsIndexWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Port>>("/port/index", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of ports using their country and deep water flag 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <returns>List&lt;Port&gt;</returns>
        public List<Port> PortsReport(PortReportRequest portReportRequest)
        {
            MaritimumClient.Client.ApiResponse<List<Port>> localVarResponse = PortsReportWithHttpInfo(portReportRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of ports using their country and deep water flag 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <returns>ApiResponse of List&lt;Port&gt;</returns>
        public MaritimumClient.Client.ApiResponse<List<Port>> PortsReportWithHttpInfo(PortReportRequest portReportRequest)
        {
            // verify the required parameter 'portReportRequest' is set
            if (portReportRequest == null)
                throw new MaritimumClient.Client.ApiException(400, "Missing required parameter 'portReportRequest' when calling PortApi->PortsReport");

            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = portReportRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<Port>>("/port/report", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of ports using their country and deep water flag 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Port&gt;</returns>
        public async System.Threading.Tasks.Task<List<Port>> PortsReportAsync(PortReportRequest portReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MaritimumClient.Client.ApiResponse<List<Port>> localVarResponse = await PortsReportWithHttpInfoAsync(portReportRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of ports using their country and deep water flag 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="portReportRequest">Used to filter the reported existing ports.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Port&gt;)</returns>
        public async System.Threading.Tasks.Task<MaritimumClient.Client.ApiResponse<List<Port>>> PortsReportWithHttpInfoAsync(PortReportRequest portReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'portReportRequest' is set
            if (portReportRequest == null)
                throw new MaritimumClient.Client.ApiException(400, "Missing required parameter 'portReportRequest' when calling PortApi->PortsReport");


            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = portReportRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<Port>>("/port/report", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a port by its UUID 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <returns>Port</returns>
        public Port PortsShow(Guid body)
        {
            MaritimumClient.Client.ApiResponse<Port> localVarResponse = PortsShowWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a port by its UUID 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <returns>ApiResponse of Port</returns>
        public MaritimumClient.Client.ApiResponse<Port> PortsShowWithHttpInfo(Guid body)
        {
            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Port>("/port/show", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsShow", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a port by its UUID 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Port</returns>
        public async System.Threading.Tasks.Task<Port> PortsShowAsync(Guid body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MaritimumClient.Client.ApiResponse<Port> localVarResponse = await PortsShowWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a port by its UUID 
        /// </summary>
        /// <exception cref="MaritimumClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UUID of the port.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Port)</returns>
        public async System.Threading.Tasks.Task<MaritimumClient.Client.ApiResponse<Port>> PortsShowWithHttpInfoAsync(Guid body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            MaritimumClient.Client.RequestOptions localVarRequestOptions = new MaritimumClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = MaritimumClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MaritimumClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Port>("/port/show", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PortsShow", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
