fx_version 'bodacious'
game 'gta5'

files {
    'LenguajePacks/server_lang.yaml',
    'Client/*.dll'
}

server_script 'Server/**.net.dll'
client_script 'Client/**.net.dll'

author 'zabbix-byte'
version '1.0.0'
description 'lenguaje selector ZTZBX Framework'

server_exports {
    "user_wrong",
    "user_parameters_login_error",
    "already_logged",
    "email_exists",
    "user_exists",
    "password_to_short",
    "user_parameters_register_error",
    "already_logged_registered",
    "not_valid_email"
}
