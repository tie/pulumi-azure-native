# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'BillingManagementTenantState',
    'InvoiceSectionState',
    'InvoiceSectionStateReasonCode',
    'ProvisioningTenantState',
]


class BillingManagementTenantState(str, Enum):
    """
    The state determines whether users from the associated tenant can be assigned roles for commerce activities like viewing and downloading invoices, managing payments, and making purchases.
    """
    OTHER = "Other"
    NOT_ALLOWED = "NotAllowed"
    ACTIVE = "Active"
    REVOKED = "Revoked"


class InvoiceSectionState(str, Enum):
    """
    Identifies the status of an invoice section.
    """
    OTHER = "Other"
    ACTIVE = "Active"
    DELETED = "Deleted"
    DISABLED = "Disabled"
    UNDER_REVIEW = "UnderReview"
    WARNED = "Warned"
    RESTRICTED = "Restricted"


class InvoiceSectionStateReasonCode(str, Enum):
    """
    Reason for the specified invoice section status.
    """
    OTHER = "Other"
    PAST_DUE = "PastDue"
    UNUSUAL_ACTIVITY = "UnusualActivity"
    SPENDING_LIMIT_REACHED = "SpendingLimitReached"
    SPENDING_LIMIT_EXPIRED = "SpendingLimitExpired"


class ProvisioningTenantState(str, Enum):
    """
    The state determines whether subscriptions and licenses can be provisioned in the associated tenant. It can be set to 'Pending' to initiate a billing request.
    """
    OTHER = "Other"
    NOT_REQUESTED = "NotRequested"
    ACTIVE = "Active"
    PENDING = "Pending"
    BILLING_REQUEST_EXPIRED = "BillingRequestExpired"
    BILLING_REQUEST_DECLINED = "BillingRequestDeclined"
    REVOKED = "Revoked"
