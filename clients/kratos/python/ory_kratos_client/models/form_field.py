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


class FormField(object):
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
        'disabled': 'bool',
        'messages': 'list[Message]',
        'name': 'str',
        'pattern': 'str',
        'required': 'bool',
        'type': 'str',
        'value': 'object'
    }

    attribute_map = {
        'disabled': 'disabled',
        'messages': 'messages',
        'name': 'name',
        'pattern': 'pattern',
        'required': 'required',
        'type': 'type',
        'value': 'value'
    }

    def __init__(self, disabled=None, messages=None, name=None, pattern=None, required=None, type=None, value=None, local_vars_configuration=None):  # noqa: E501
        """FormField - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._disabled = None
        self._messages = None
        self._name = None
        self._pattern = None
        self._required = None
        self._type = None
        self._value = None
        self.discriminator = None

        if disabled is not None:
            self.disabled = disabled
        if messages is not None:
            self.messages = messages
        self.name = name
        if pattern is not None:
            self.pattern = pattern
        if required is not None:
            self.required = required
        self.type = type
        if value is not None:
            self.value = value

    @property
    def disabled(self):
        """Gets the disabled of this FormField.  # noqa: E501

        Disabled is the equivalent of `<input {{if .Disabled}}disabled{{end}}\">`  # noqa: E501

        :return: The disabled of this FormField.  # noqa: E501
        :rtype: bool
        """
        return self._disabled

    @disabled.setter
    def disabled(self, disabled):
        """Sets the disabled of this FormField.

        Disabled is the equivalent of `<input {{if .Disabled}}disabled{{end}}\">`  # noqa: E501

        :param disabled: The disabled of this FormField.  # noqa: E501
        :type: bool
        """

        self._disabled = disabled

    @property
    def messages(self):
        """Gets the messages of this FormField.  # noqa: E501


        :return: The messages of this FormField.  # noqa: E501
        :rtype: list[Message]
        """
        return self._messages

    @messages.setter
    def messages(self, messages):
        """Sets the messages of this FormField.


        :param messages: The messages of this FormField.  # noqa: E501
        :type: list[Message]
        """

        self._messages = messages

    @property
    def name(self):
        """Gets the name of this FormField.  # noqa: E501

        Name is the equivalent of `<input name=\"{{.Name}}\">`  # noqa: E501

        :return: The name of this FormField.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this FormField.

        Name is the equivalent of `<input name=\"{{.Name}}\">`  # noqa: E501

        :param name: The name of this FormField.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and name is None:  # noqa: E501
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def pattern(self):
        """Gets the pattern of this FormField.  # noqa: E501

        Pattern is the equivalent of `<input pattern=\"{{.Pattern}}\">`  # noqa: E501

        :return: The pattern of this FormField.  # noqa: E501
        :rtype: str
        """
        return self._pattern

    @pattern.setter
    def pattern(self, pattern):
        """Sets the pattern of this FormField.

        Pattern is the equivalent of `<input pattern=\"{{.Pattern}}\">`  # noqa: E501

        :param pattern: The pattern of this FormField.  # noqa: E501
        :type: str
        """

        self._pattern = pattern

    @property
    def required(self):
        """Gets the required of this FormField.  # noqa: E501

        Required is the equivalent of `<input required=\"{{.Required}}\">`  # noqa: E501

        :return: The required of this FormField.  # noqa: E501
        :rtype: bool
        """
        return self._required

    @required.setter
    def required(self, required):
        """Sets the required of this FormField.

        Required is the equivalent of `<input required=\"{{.Required}}\">`  # noqa: E501

        :param required: The required of this FormField.  # noqa: E501
        :type: bool
        """

        self._required = required

    @property
    def type(self):
        """Gets the type of this FormField.  # noqa: E501

        Type is the equivalent of `<input type=\"{{.Type}}\">`  # noqa: E501

        :return: The type of this FormField.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this FormField.

        Type is the equivalent of `<input type=\"{{.Type}}\">`  # noqa: E501

        :param type: The type of this FormField.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and type is None:  # noqa: E501
            raise ValueError("Invalid value for `type`, must not be `None`")  # noqa: E501

        self._type = type

    @property
    def value(self):
        """Gets the value of this FormField.  # noqa: E501

        Value is the equivalent of `<input value=\"{{.Value}}\">`  # noqa: E501

        :return: The value of this FormField.  # noqa: E501
        :rtype: object
        """
        return self._value

    @value.setter
    def value(self, value):
        """Sets the value of this FormField.

        Value is the equivalent of `<input value=\"{{.Value}}\">`  # noqa: E501

        :param value: The value of this FormField.  # noqa: E501
        :type: object
        """

        self._value = value

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
        if not isinstance(other, FormField):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, FormField):
            return True

        return self.to_dict() != other.to_dict()
