=begin
#Ory Kratos

#Welcome to the ORY Kratos HTTP API documentation!

The version of the OpenAPI document: v0.5.2-alpha.1

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

# Common files
require 'ory-kratos-client/api_client'
require 'ory-kratos-client/api_error'
require 'ory-kratos-client/version'
require 'ory-kratos-client/configuration'

# Models
require 'ory-kratos-client/models/complete_self_service_login_flow_with_password_method'
require 'ory-kratos-client/models/complete_self_service_recovery_flow_with_link_method'
require 'ory-kratos-client/models/complete_self_service_settings_flow_with_password_method'
require 'ory-kratos-client/models/complete_self_service_verification_flow_with_link_method'
require 'ory-kratos-client/models/create_identity'
require 'ory-kratos-client/models/create_recovery_link'
require 'ory-kratos-client/models/error_container'
require 'ory-kratos-client/models/form_field'
require 'ory-kratos-client/models/generic_error'
require 'ory-kratos-client/models/generic_error_payload'
require 'ory-kratos-client/models/health_not_ready_status'
require 'ory-kratos-client/models/health_status'
require 'ory-kratos-client/models/identity'
require 'ory-kratos-client/models/login_flow'
require 'ory-kratos-client/models/login_flow_method'
require 'ory-kratos-client/models/login_flow_method_config'
require 'ory-kratos-client/models/login_via_api_response'
require 'ory-kratos-client/models/message'
require 'ory-kratos-client/models/recovery_address'
require 'ory-kratos-client/models/recovery_flow'
require 'ory-kratos-client/models/recovery_flow_method'
require 'ory-kratos-client/models/recovery_flow_method_config'
require 'ory-kratos-client/models/recovery_link'
require 'ory-kratos-client/models/registration_flow'
require 'ory-kratos-client/models/registration_flow_method'
require 'ory-kratos-client/models/registration_flow_method_config'
require 'ory-kratos-client/models/registration_via_api_response'
require 'ory-kratos-client/models/revoke_session'
require 'ory-kratos-client/models/session'
require 'ory-kratos-client/models/settings_flow'
require 'ory-kratos-client/models/settings_flow_method'
require 'ory-kratos-client/models/settings_flow_method_config'
require 'ory-kratos-client/models/settings_via_api_response'
require 'ory-kratos-client/models/update_identity'
require 'ory-kratos-client/models/verifiable_address'
require 'ory-kratos-client/models/verification_flow'
require 'ory-kratos-client/models/verification_flow_method'
require 'ory-kratos-client/models/verification_flow_method_config'
require 'ory-kratos-client/models/version'

# APIs
require 'ory-kratos-client/api/admin_api'
require 'ory-kratos-client/api/health_api'
require 'ory-kratos-client/api/public_api'
require 'ory-kratos-client/api/version_api'

module OryHydraClient
  class << self
    # Customize default settings for the SDK using block.
    #   OryHydraClient.configure do |config|
    #     config.username = "xxx"
    #     config.password = "xxx"
    #   end
    # If no block given, return the default Configuration object.
    def configure
      if block_given?
        yield(Configuration.default)
      else
        Configuration.default
      end
    end
  end
end
