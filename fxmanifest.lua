fx_version 'bodacious'
game 'gta5'

files {
    'languagePacks/lang.yaml'
}

server_script 'Server/**.net.dll'

author 'zabbix-byte'
version '1.0.0'
description 'language selector ZTZBX Framework'

server_exports {
    "user_wrong",
    "user_parameters_login_error",
    "already_logged",
    "email_exists",
    "user_exists",
    "password_to_short",
    "user_parameters_register_error",
    "already_logged_registered",
    "not_valid_email",
    "no_username",
    "no_password",
    "no_email"
}
