using System.Net;

namespace Bartender.Net.Framework.Exceptions;

public class BartenderHttpRequestException : HttpRequestException {
    public BartenderHttpRequestException () {
    }

    public BartenderHttpRequestException (string? message) : base (message) {
    }

    public BartenderHttpRequestException (string? message, Exception? inner) : base (message, inner) {
    }

    public BartenderHttpRequestException (string? message, Exception? inner, HttpStatusCode? statusCode) : base (message, inner, statusCode) {
    }

    public BartenderHttpRequestException (HttpRequestError httpRequestError, string? message = null, Exception? inner = null, HttpStatusCode? statusCode = null) : base (httpRequestError, message, inner, statusCode) {
    }
}

public class BartenderNullOrWhiteSpaceKeyException : HttpRequestException {
    public BartenderNullOrWhiteSpaceKeyException () {
    }

    public BartenderNullOrWhiteSpaceKeyException (string? message) : base (message) {
    }

    public BartenderNullOrWhiteSpaceKeyException (string? message, Exception? inner) : base (message, inner) {
    }

    public BartenderNullOrWhiteSpaceKeyException (string? message, Exception? inner, HttpStatusCode? statusCode) : base (message, inner, statusCode) {
    }

    public BartenderNullOrWhiteSpaceKeyException (HttpRequestError httpRequestError, string? message = null, Exception? inner = null, HttpStatusCode? statusCode = null) : base (httpRequestError, message, inner, statusCode) {
    }
}