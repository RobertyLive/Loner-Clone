<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Microsoft.AspNetCore.Authorization</name>
    </assembly>
    <members>
        <member name="T:Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute">
            <summary>
            Specifies that the class or method that this attribute is applied to does not require authorization.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute.ToString">
            <inheritdoc/>
        </member>
        <member name="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement">
            <summary>
            Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler"/> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement"/>
            that takes a user specified assertion.
            </summary>
        </member>
        <member name="P:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.Handler">
            <summary>
            Function that is called to handle this requirement.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.#ctor(System.Func{Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext,System.Boolean})">
            <summary>
            Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement"/>.
            </summary>
            <param name="handler">Function that is called to handle this requirement.</param>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.#ctor(System.Func{Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext,System.Threading.Tasks.Task{System.Boolean}})">
            <summary>
            Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement"/>.
            </summary>
            <param name="handler">Function that is called to handle this requirement.</param>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.HandleAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext)">
            <summary>
            Calls <see cref="P:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.Handler"/> to see if authorization is allowed.
            </summary>
            <param name="context">The authorization information.</param>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.ToString">
            <inheritdoc />
        </member>
        <member name="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement">
            <summary>
            Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler"/> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement"/>
            which requires at least one instance of the specified claim type, and, if allowed values are specified,
            the claim value must be any of the allowed values.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement.#ctor(System.String,System.Collections.Generic.IEnumerable{System.String})">
            <summary>
            Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement"/>.
            </summary>
            <param name="claimType">The claim type that must be present.</param>
            <param name="allowedValues">Optional list of claim values. If specified, the claim must match one or more of these values.</param>
        </member>
        <member name="P:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement.ClaimType">
            <summary>
            Gets the claim type that must be present.
            </summary>
        </member>
        <member name="P:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement.AllowedValues">
            <summary>
            Gets the optional list of claim values, which, if present,
            the claim must match.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement.HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext,Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement)">
            <summary>
            Makes a decision if aut