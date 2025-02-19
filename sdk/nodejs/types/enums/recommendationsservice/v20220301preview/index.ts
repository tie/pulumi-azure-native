// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const AccountConfiguration = {
    Free: "Free",
    Capacity: "Capacity",
} as const;

/**
 * Account configuration. This can only be set at RecommendationsService Account creation.
 */
export type AccountConfiguration = (typeof AccountConfiguration)[keyof typeof AccountConfiguration];

export const ManagedServiceIdentityType = {
    None: "None",
    SystemAssigned: "SystemAssigned",
    UserAssigned: "UserAssigned",
    SystemAssigned_UserAssigned: "SystemAssigned,UserAssigned",
} as const;

/**
 * Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
 */
export type ManagedServiceIdentityType = (typeof ManagedServiceIdentityType)[keyof typeof ManagedServiceIdentityType];

export const ModelingFeatures = {
    Basic: "Basic",
    Standard: "Standard",
    Premium: "Premium",
} as const;

/**
 * Modeling features controls the set of supported scenarios\models being computed. This can only be set at Modeling creation.
 */
export type ModelingFeatures = (typeof ModelingFeatures)[keyof typeof ModelingFeatures];

export const ModelingFrequency = {
    Low: "Low",
    Medium: "Medium",
    High: "High",
} as const;

/**
 * Modeling frequency controls the modeling compute frequency.
 */
export type ModelingFrequency = (typeof ModelingFrequency)[keyof typeof ModelingFrequency];

export const ModelingSize = {
    Small: "Small",
    Medium: "Medium",
    Large: "Large",
} as const;

/**
 * Modeling size controls the maximum supported input data size.
 */
export type ModelingSize = (typeof ModelingSize)[keyof typeof ModelingSize];

export const PrincipalType = {
    Application: "Application",
    User: "User",
} as const;

/**
 * AAD principal type.
 */
export type PrincipalType = (typeof PrincipalType)[keyof typeof PrincipalType];
