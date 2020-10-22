# coding: utf-8

"""
    Ory Kratos

    Welcome to the ORY Kratos HTTP API documentation!  # noqa: E501

    The version of the OpenAPI document: v0.5.2-alpha.1
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from ory_kratos_client.configuration import Configuration


class RecoveryLink(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'expires_at': 'datetime',
        'recovery_link': 'str'
    }

    attribute_map = {
        'expires_at': 'expires_at',
        'recovery_link': 'recovery_link'
    }

    def __init__(self, expires_at=None, recovery_link=None, local_vars_configuration=None):  # noqa: E501
        """RecoveryLink - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._expires_at = None
        self._recovery_link = None
        self.discriminator = None

        if expires_at is not None:
            self.expires_at = expires_at
        self.recovery_link = recovery_link

    @property
    def expires_at(self):
        """Gets the expires_at of this RecoveryLink.  # noqa: E501

        Recovery Link Expires At  The timestamp when the recovery link expires.  # noqa: E501

        :return: The expires_at of this RecoveryLink.  # noqa: E501
        :rtype: datetime
        """
        return self._expires_at

    @expires_at.setter
    def expires_at(self, expires_at):
        """Sets the expires_at of this RecoveryLink.

        Recovery Link Expires At  The timestamp when the recovery link expires.  # noqa: E501

        :param expires_at: The expires_at of this RecoveryLink.  # noqa: E501
        :type: datetime
        """

        self._expires_at = expires_at

    @property
    def recovery_link(self):
        """Gets the recovery_link of this RecoveryLink.  # noqa: E501

        Recovery Link  This link can be used to recover the account.  # noqa: E501

        :return: The recovery_link of this RecoveryLink.  # noqa: E501
        :rtype: str
        """
        return self._recovery_link

    @recovery_link.setter
    def recovery_link(self, recovery_link):
        """Sets the recovery_link of this RecoveryLink.

        Recovery Link  This link can be used to recover the account.  # noqa: E501

        :param recovery_link: The recovery_link of this RecoveryLink.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and recovery_link is None:  # noqa: E501
            raise ValueError("Invalid value for `recovery_link`, must not be `None`")  # noqa: E501

        self._recovery_link = recovery_link

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, RecoveryLink):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, RecoveryLink):
            return True

        return self.to_dict() != other.to_dict()
