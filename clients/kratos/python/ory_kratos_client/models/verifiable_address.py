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


class VerifiableAddress(object):
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
        'id': 'str',
        'status': 'str',
        'value': 'str',
        'verified': 'bool',
        'verified_at': 'datetime',
        'via': 'str'
    }

    attribute_map = {
        'id': 'id',
        'status': 'status',
        'value': 'value',
        'verified': 'verified',
        'verified_at': 'verified_at',
        'via': 'via'
    }

    def __init__(self, id=None, status=None, value=None, verified=None, verified_at=None, via=None, local_vars_configuration=None):  # noqa: E501
        """VerifiableAddress - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._id = None
        self._status = None
        self._value = None
        self._verified = None
        self._verified_at = None
        self._via = None
        self.discriminator = None

        self.id = id
        self.status = status
        self.value = value
        self.verified = verified
        if verified_at is not None:
            self.verified_at = verified_at
        self.via = via

    @property
    def id(self):
        """Gets the id of this VerifiableAddress.  # noqa: E501


        :return: The id of this VerifiableAddress.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this VerifiableAddress.


        :param id: The id of this VerifiableAddress.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and id is None:  # noqa: E501
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def status(self):
        """Gets the status of this VerifiableAddress.  # noqa: E501


        :return: The status of this VerifiableAddress.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this VerifiableAddress.


        :param status: The status of this VerifiableAddress.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and status is None:  # noqa: E501
            raise ValueError("Invalid value for `status`, must not be `None`")  # noqa: E501

        self._status = status

    @property
    def value(self):
        """Gets the value of this VerifiableAddress.  # noqa: E501


        :return: The value of this VerifiableAddress.  # noqa: E501
        :rtype: str
        """
        return self._value

    @value.setter
    def value(self, value):
        """Sets the value of this VerifiableAddress.


        :param value: The value of this VerifiableAddress.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and value is None:  # noqa: E501
            raise ValueError("Invalid value for `value`, must not be `None`")  # noqa: E501

        self._value = value

    @property
    def verified(self):
        """Gets the verified of this VerifiableAddress.  # noqa: E501


        :return: The verified of this VerifiableAddress.  # noqa: E501
        :rtype: bool
        """
        return self._verified

    @verified.setter
    def verified(self, verified):
        """Sets the verified of this VerifiableAddress.


        :param verified: The verified of this VerifiableAddress.  # noqa: E501
        :type: bool
        """
        if self.local_vars_configuration.client_side_validation and verified is None:  # noqa: E501
            raise ValueError("Invalid value for `verified`, must not be `None`")  # noqa: E501

        self._verified = verified

    @property
    def verified_at(self):
        """Gets the verified_at of this VerifiableAddress.  # noqa: E501


        :return: The verified_at of this VerifiableAddress.  # noqa: E501
        :rtype: datetime
        """
        return self._verified_at

    @verified_at.setter
    def verified_at(self, verified_at):
        """Sets the verified_at of this VerifiableAddress.


        :param verified_at: The verified_at of this VerifiableAddress.  # noqa: E501
        :type: datetime
        """

        self._verified_at = verified_at

    @property
    def via(self):
        """Gets the via of this VerifiableAddress.  # noqa: E501


        :return: The via of this VerifiableAddress.  # noqa: E501
        :rtype: str
        """
        return self._via

    @via.setter
    def via(self, via):
        """Sets the via of this VerifiableAddress.


        :param via: The via of this VerifiableAddress.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and via is None:  # noqa: E501
            raise ValueError("Invalid value for `via`, must not be `None`")  # noqa: E501

        self._via = via

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
        if not isinstance(other, VerifiableAddress):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, VerifiableAddress):
            return True

        return self.to_dict() != other.to_dict()
