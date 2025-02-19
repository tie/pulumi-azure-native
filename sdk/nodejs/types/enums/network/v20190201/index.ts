// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const Access = {
    Allow: "Allow",
    Deny: "Deny",
} as const;

/**
 * The access type of the rule.
 */
export type Access = (typeof Access)[keyof typeof Access];

export const DdosSettingsProtectionCoverage = {
    Basic: "Basic",
    Standard: "Standard",
} as const;

/**
 * The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.
 */
export type DdosSettingsProtectionCoverage = (typeof DdosSettingsProtectionCoverage)[keyof typeof DdosSettingsProtectionCoverage];

export const ExpressRouteCircuitPeeringAdvertisedPublicPrefixState = {
    NotConfigured: "NotConfigured",
    Configuring: "Configuring",
    Configured: "Configured",
    ValidationNeeded: "ValidationNeeded",
} as const;

/**
 * AdvertisedPublicPrefixState of the Peering resource. Possible values are 'NotConfigured', 'Configuring', 'Configured', and 'ValidationNeeded'.
 */
export type ExpressRouteCircuitPeeringAdvertisedPublicPrefixState = (typeof ExpressRouteCircuitPeeringAdvertisedPublicPrefixState)[keyof typeof ExpressRouteCircuitPeeringAdvertisedPublicPrefixState];

export const ExpressRouteCircuitPeeringState = {
    Disabled: "Disabled",
    Enabled: "Enabled",
} as const;

/**
 * The state of peering. Possible values are: 'Disabled' and 'Enabled'
 */
export type ExpressRouteCircuitPeeringState = (typeof ExpressRouteCircuitPeeringState)[keyof typeof ExpressRouteCircuitPeeringState];

export const ExpressRoutePeeringState = {
    Disabled: "Disabled",
    Enabled: "Enabled",
} as const;

/**
 * The peering state.
 */
export type ExpressRoutePeeringState = (typeof ExpressRoutePeeringState)[keyof typeof ExpressRoutePeeringState];

export const ExpressRoutePeeringType = {
    AzurePublicPeering: "AzurePublicPeering",
    AzurePrivatePeering: "AzurePrivatePeering",
    MicrosoftPeering: "MicrosoftPeering",
} as const;

/**
 * The peering type.
 */
export type ExpressRoutePeeringType = (typeof ExpressRoutePeeringType)[keyof typeof ExpressRoutePeeringType];

export const IPAllocationMethod = {
    Static: "Static",
    Dynamic: "Dynamic",
} as const;

/**
 * The Private IP allocation method.
 */
export type IPAllocationMethod = (typeof IPAllocationMethod)[keyof typeof IPAllocationMethod];

export const IPVersion = {
    IPv4: "IPv4",
    IPv6: "IPv6",
} as const;

/**
 * The public IP address version.
 */
export type IPVersion = (typeof IPVersion)[keyof typeof IPVersion];

export const PublicIPAddressSkuName = {
    Basic: "Basic",
    Standard: "Standard",
} as const;

/**
 * Name of a public IP address SKU.
 */
export type PublicIPAddressSkuName = (typeof PublicIPAddressSkuName)[keyof typeof PublicIPAddressSkuName];

export const RouteFilterRuleType = {
    Community: "Community",
} as const;

/**
 * The rule type of the rule. Valid value is: 'Community'
 */
export type RouteFilterRuleType = (typeof RouteFilterRuleType)[keyof typeof RouteFilterRuleType];

export const RouteNextHopType = {
    VirtualNetworkGateway: "VirtualNetworkGateway",
    VnetLocal: "VnetLocal",
    Internet: "Internet",
    VirtualAppliance: "VirtualAppliance",
    None: "None",
} as const;

/**
 * The type of Azure hop the packet should be sent to.
 */
export type RouteNextHopType = (typeof RouteNextHopType)[keyof typeof RouteNextHopType];

export const SecurityRuleAccess = {
    Allow: "Allow",
    Deny: "Deny",
} as const;

/**
 * The network traffic is allowed or denied.
 */
export type SecurityRuleAccess = (typeof SecurityRuleAccess)[keyof typeof SecurityRuleAccess];

export const SecurityRuleDirection = {
    Inbound: "Inbound",
    Outbound: "Outbound",
} as const;

/**
 * The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
 */
export type SecurityRuleDirection = (typeof SecurityRuleDirection)[keyof typeof SecurityRuleDirection];

export const SecurityRuleProtocol = {
    Tcp: "Tcp",
    Udp: "Udp",
    Icmp: "Icmp",
    Esp: "Esp",
    Asterisk: "*",
} as const;

/**
 * Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', 'Icmp', 'Esp', and '*'.
 */
export type SecurityRuleProtocol = (typeof SecurityRuleProtocol)[keyof typeof SecurityRuleProtocol];

export const TransportProtocol = {
    Udp: "Udp",
    Tcp: "Tcp",
    All: "All",
} as const;

/**
 * The reference to the transport protocol used by the load balancing rule.
 */
export type TransportProtocol = (typeof TransportProtocol)[keyof typeof TransportProtocol];
