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


class Session(object):
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
        'active': 'bool',
        'authenticated_at': 'datetime',
        'expires_at': 'datetime',
        'id': 'str',
        'identity': 'Identity',
        'issued_at': 'datetime'
    }

    attribute_map = {
        'active': 'active',
        'authenticated_at': 'authenticated_at',
        'expires_at': 'expires_at',
        'id': 'id',
        'identity': 'identity',
        'issued_at': 'issued_at'
    }

    def __init__(self, active=None, authenticated_at=None, expires_at=None, id=None, identity=None, issued_at=None, local_vars_configuration=None):  # noqa: E501
        """Session - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._active = None
        self._authenticated_at = None
        self._expires_at = None
        self._id = None
        self._identity = None
        self._issued_at = None
        self.discriminator = None

        if active is not None:
            self.active = active
        self.authenticated_at = authenticated_at
        self.expires_at = expires_at
        self.id = id
        self.identity = identity
        self.issued_at = issued_at

    @property
    def active(self):
        """Gets the active of this Session.  # noqa: E501


        :return: The active of this Session.  # noqa: E501
        :rtype: bool
        """
        return self._active

    @active.setter
    def active(self, active):
        """Sets the active of this Session.


        :param active: The active of this Session.  # noqa: E501
        :type: bool
        """

        self._active = active

    @property
    def authenticated_at(self):
        """Gets the authenticated_at of this Session.  # noqa: E501


        :return: The authenticated_at of this Session.  # noqa: E501
        :rtype: datetime
        """
        return self._authenticated_at

    @authenticated_at.setter
    def authenticated_at(self, authenticated_at):
        """Sets the authenticated_at of this Session.


        :param authenticated_at: The authenticated_at of this Session.  # noqa: E501
        :type: datetime
        """
        if self.local_vars_configuration.client_side_validation and authenticated_at is None:  # noqa: E501
            raise ValueError("Invalid value for `authenticated_at`, must not be `None`")  # noqa: E501

        self._authenticated_at = authenticated_at

    @property
    def expires_at(self):
        """Gets the expires_at of this Session.  # noqa: E501


        :return: The expires_at of this Session.  # noqa: E501
        :rtype: datetime
        """
        return self._expires_at

    @expires_at.setter
    def expires_at(self, expires_at):
        """Sets the expires_at of this Session.


        :param expires_at: The expires_at of this Session.  # noqa: E501
        :type: datetime
        """
        if self.local_vars_configuration.client_side_validation and expires_at is None:  # noqa: E501
            raise ValueError("Invalid value for `expires_at`, must not be `None`")  # noqa: E501

        self._expires_at = expires_at

    @property
    def id(self):
        """Gets the id of this Session.  # noqa: E501


        :return: The id of this Session.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Session.


        :param id: The id of this Session.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and id is None:  # noqa: E501
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def identity(self):
        """Gets the identity of this Session.  # noqa: E501


        :return: The identity of this Session.  # noqa: E501
        :rtype: Identity
        """
        return self._identity

    @identity.setter
    def identity(self, identity):
        """Sets the identity of this Session.


        :param identity: The identity of this Session.  # noqa: E501
        :type: Identity
        """
        if self.local_vars_configuration.client_side_validation and identity is None:  # noqa: E501
            raise ValueError("Invalid value for `identity`, must not be `None`")  # noqa: E501

        self._identity = identity

    @property
    def issued_at(self):
        """Gets the issued_at of this Session.  # noqa: E501


        :return: The issued_at of this Session.  # noqa: E501
        :rtype: datetime
        """
        return self._issued_at

    @issued_at.setter
    def issued_at(self, issued_at):
        """Sets the issued_at of this Session.


        :param issued_at: The issued_at of this Session.  # noqa: E501
        :type: datetime
        """
        if self.local_vars_configuration.client_side_validation and issued_at is None:  # noqa: E501
            raise ValueError("Invalid value for `issued_at`, must not be `None`")  # noqa: E501

        self._issued_at = issued_at

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
        if not isinstance(other, Session):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Session):
            return True

        return self.to_dict() != other.to_dict()
