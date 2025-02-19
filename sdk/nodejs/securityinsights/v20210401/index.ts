// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export { GetThreatIntelligenceIndicatorArgs, GetThreatIntelligenceIndicatorResult, GetThreatIntelligenceIndicatorOutputArgs } from "./getThreatIntelligenceIndicator";
export const getThreatIntelligenceIndicator: typeof import("./getThreatIntelligenceIndicator").getThreatIntelligenceIndicator = null as any;
export const getThreatIntelligenceIndicatorOutput: typeof import("./getThreatIntelligenceIndicator").getThreatIntelligenceIndicatorOutput = null as any;
utilities.lazyLoad(exports, ["getThreatIntelligenceIndicator","getThreatIntelligenceIndicatorOutput"], () => require("./getThreatIntelligenceIndicator"));

export { GetWatchlistArgs, GetWatchlistResult, GetWatchlistOutputArgs } from "./getWatchlist";
export const getWatchlist: typeof import("./getWatchlist").getWatchlist = null as any;
export const getWatchlistOutput: typeof import("./getWatchlist").getWatchlistOutput = null as any;
utilities.lazyLoad(exports, ["getWatchlist","getWatchlistOutput"], () => require("./getWatchlist"));

export { GetWatchlistItemArgs, GetWatchlistItemResult, GetWatchlistItemOutputArgs } from "./getWatchlistItem";
export const getWatchlistItem: typeof import("./getWatchlistItem").getWatchlistItem = null as any;
export const getWatchlistItemOutput: typeof import("./getWatchlistItem").getWatchlistItemOutput = null as any;
utilities.lazyLoad(exports, ["getWatchlistItem","getWatchlistItemOutput"], () => require("./getWatchlistItem"));

export { ThreatIntelligenceIndicatorArgs } from "./threatIntelligenceIndicator";
export type ThreatIntelligenceIndicator = import("./threatIntelligenceIndicator").ThreatIntelligenceIndicator;
export const ThreatIntelligenceIndicator: typeof import("./threatIntelligenceIndicator").ThreatIntelligenceIndicator = null as any;
utilities.lazyLoad(exports, ["ThreatIntelligenceIndicator"], () => require("./threatIntelligenceIndicator"));

export { WatchlistArgs } from "./watchlist";
export type Watchlist = import("./watchlist").Watchlist;
export const Watchlist: typeof import("./watchlist").Watchlist = null as any;
utilities.lazyLoad(exports, ["Watchlist"], () => require("./watchlist"));

export { WatchlistItemArgs } from "./watchlistItem";
export type WatchlistItem = import("./watchlistItem").WatchlistItem;
export const WatchlistItem: typeof import("./watchlistItem").WatchlistItem = null as any;
utilities.lazyLoad(exports, ["WatchlistItem"], () => require("./watchlistItem"));


// Export enums:
export * from "../../types/enums/securityinsights/v20210401";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:securityinsights/v20210401:ThreatIntelligenceIndicator":
                return new ThreatIntelligenceIndicator(name, <any>undefined, { urn })
            case "azure-native:securityinsights/v20210401:Watchlist":
                return new Watchlist(name, <any>undefined, { urn })
            case "azure-native:securityinsights/v20210401:WatchlistItem":
                return new WatchlistItem(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "securityinsights/v20210401", _module)
