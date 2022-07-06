using System;
using Newtonsoft.Json;
#if !NETSTANDARD1_3
using System.Runtime.Serialization;
#endif
using PodioAPI.Utils;

namespace PodioAPI.Exceptions
{
#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioException : Exception
    {
        /// <summary>
        ///     Response from the API
        /// </summary>
        public PodioError Error { get; internal set; }

        /// <summary>
        ///   HTTP Status code of the response
        /// </summary>
        public long StatusCode { get; internal set; }

        public PodioException(long statusCode, PodioError error) : base(JSONSerializer.Serilaize(error))
        {
            this.Error = error;
            this.StatusCode = statusCode;
        }

#if !NETSTANDARD1_3
        public PodioException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }


#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioInvalidGrantException : PodioException
    {
        public PodioInvalidGrantException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioInvalidGrantException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }


#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioBadRequestException : PodioException
    {
        public PodioBadRequestException(long status, PodioError error)
            : base(status, error)
        {
        }


#if !NETSTANDARD1_3
        public PodioBadRequestException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }


#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioAuthorizationException : PodioException
    {
        public PodioAuthorizationException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioAuthorizationException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioForbiddenException : PodioException
    {
        public PodioForbiddenException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioForbiddenException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioNotFoundException : PodioException
    {
        public PodioNotFoundException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioNotFoundException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioConflictException : PodioException
    {
        public PodioConflictException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioConflictException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioGoneException : PodioException
    {
        public PodioGoneException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioGoneException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioRateLimitException : PodioException
    {
        public PodioRateLimitException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioRateLimitException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }

#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class PodioServerException : PodioException
    {
        public PodioServerException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioServerException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }


    public class PodioUnavailableException : PodioException
    {
        public PodioUnavailableException(long status, PodioError error)
            : base(status, error)
        {
        }

#if !NETSTANDARD1_3
        public PodioUnavailableException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
#endif
    }
    public class PodioInvalidJsonException : PodioException
    {
        public PodioInvalidJsonException(long status, PodioError error)
            : base(status, error)
        {
        }
#if !NETSTANDARD1_3
        public PodioInvalidJsonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
    /// <summary>
    ///     Represent the error response from API
    /// </summary>
    public class PodioError
    {
        [JsonProperty(PropertyName = "error_propagate")]
        public bool ErrorPropagate { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty(PropertyName = "error_detail")]
        public string ErrorDetail { get; set; }

        [JsonProperty(PropertyName = "request")]
        public Request Request { get; set; }
    }

    public class Request
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "query_string")]
        public string QueryString { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }
    }
}