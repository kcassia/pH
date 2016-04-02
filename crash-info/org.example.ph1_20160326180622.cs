S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: ph1
PID: 4675
Date: 2016-03-26 18:06:22+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x00000000
ebp = 0xbfd160b8, esp = 0xbfd16080
eax = 0xb45ce11c, ebx = 0xb6987e40
ecx = 0x00000000, edx = 0xb868db90
eip = 0xb45cd986

Memory Information
MemTotal:      124 KB
MemFree:        61 KB
Buffers:         3 KB
Cached:     142692 KB
VmPeak:      73804 KB
VmSize:      73804 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14844 KB
VmRSS:       14844 KB
VmData:      12488 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31680 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4675 TID = 4675
4675 4679 

Maps Information
b334d000 b334e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b334f000 b3357000 r-xp /usr/lib/libfeedback.so.0.1.4
b3363000 b3364000 r-xp /usr/lib/edje/modules/feedback/linux-gnu-i686-1.0.0/module.so
b35d6000 b35d7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b35d8000 b35da000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b35db000 b35ff000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b37a1000 b37a4000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b37a5000 b37b3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b37b4000 b37c3000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3fc8000 b3fcb000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3fcc000 b3fcf000 r-xp /usr/lib/libdri2.so.0.0.0
b3fd0000 b3fdb000 r-xp /usr/lib/libdrm.so.2.4.0
b3fdc000 b3fe5000 r-xp /usr/lib/libtbm.so.1.0.0
b3fe6000 b3fed000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3fee000 b3ff7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3ff8000 b3fff000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4000000 b4008000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4009000 b400f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4010000 b4154000 r-xp /usr/lib/libcairo.so.2.11200.14
b4158000 b4175000 r-xp /usr/lib/libtts.so
b4176000 b418e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b418f000 b419f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b41a0000 b41ab000 r-xp /lib/libnss_files-2.13.so
b43ec000 b4413000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4414000 b4439000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b443a000 b455b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b456b000 b45a1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b45a3000 b45a6000 r-xp /usr/lib/libiniparser.so.0
b45a8000 b45b2000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45b3000 b45bc000 r-xp /usr/lib/libappsvc.so.0.1.0
b45bd000 b45c0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45c4000 b45c6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45c7000 b45cb000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b45cc000 b45ce000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
b45cf000 b45d5000 r-xp /usr/lib/libogg.so.0.7.1
b45d6000 b4601000 r-xp /usr/lib/libvorbis.so.0.4.3
b4602000 b46ed000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46fb000 b46fd000 r-xp /usr/lib/libXau.so.6.0.0
b46fe000 b475e000 r-xp /usr/lib/libssl.so.1.0.0
b4763000 b4794000 r-xp /usr/lib/libidn.so.11.5.44
b4795000 b47a5000 r-xp /usr/lib/libcares.so.2.1.0
b47a6000 b480f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4815000 b481f000 r-xp /usr/lib/libsensord-share.so
b4820000 b4846000 r-xp /lib/libexpat.so.1.5.2
b4848000 b486f000 r-xp /usr/lib/libpng12.so.0.50.0
b4870000 b4890000 r-xp /usr/lib/libxcb.so.1.1.0
b4891000 b4900000 r-xp /usr/lib/libcurl.so.4.3.0
b4902000 b490d000 r-xp /usr/lib/libethumb.so.1.7.99
b5e6d000 b5f45000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f51000 b5f54000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f55000 b5f6b000 r-xp /usr/lib/libremix.so.0.0.0
b5f6c000 b5f6e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f6f000 b5f9b000 r-xp /usr/lib/liblua-5.1.so
b5f9c000 b5fa6000 r-xp /usr/lib/libembryo.so.1.7.99
b5fa7000 b5fed000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ffe000 b601c000 r-xp /usr/lib/libsensor.so.1.1.0
b601e000 b60a0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b60a5000 b60d9000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60db000 b6136000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6138000 b614e000 r-xp /usr/lib/libfribidi.so.0.3.1
b614f000 b61db000 r-xp /usr/lib/libfreetype.so.6.11.3
b61df000 b61e2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61e3000 b61e9000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61ea000 b61f0000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61f2000 b6203000 r-xp /usr/lib/libXext.so.6.4.0
b6204000 b6338000 r-xp /usr/lib/libX11.so.6.3.0
b633c000 b6341000 r-xp /usr/lib/libXtst.so.6.1.0
b6342000 b634a000 r-xp /usr/lib/libXrender.so.1.3.0
b634b000 b6354000 r-xp /usr/lib/libXrandr.so.2.2.0
b6355000 b6357000 r-xp /usr/lib/libXinerama.so.1.0.0
b6358000 b6366000 r-xp /usr/lib/libXi.so.6.1.0
b6367000 b636b000 r-xp /usr/lib/libXfixes.so.3.1.0
b636c000 b636e000 r-xp /usr/lib/libXgesture.so.7.0.0
b636f000 b6371000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6372000 b6374000 r-xp /usr/lib/libXdamage.so.1.1.0
b6375000 b637e000 r-xp /usr/lib/libXcursor.so.1.0.2
b637f000 b63aa000 r-xp /usr/lib/libecore_con.so.1.7.99
b63ac000 b63b4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63b5000 b63c0000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63c1000 b63c7000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63c8000 b63e9000 r-xp /usr/lib/libefreet.so.1.7.99
b63eb000 b63f7000 r-xp /usr/lib/libedbus.so.1.7.99
b63f8000 b6557000 r-xp /usr/lib/libicuuc.so.51.1
b6565000 b676e000 r-xp /usr/lib/libicui18n.so.51.1
b6777000 b6814000 r-xp /usr/lib/libedje.so.1.7.99
b6816000 b6827000 r-xp /usr/lib/libecore_input.so.1.7.99
b6828000 b682f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6830000 b6856000 r-xp /usr/lib/libeet.so.1.7.99
b685f000 b6987000 r-xp /usr/lib/libevas.so.1.7.99
b69a4000 b69d7000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69d9000 b6a1d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a1f000 b6c19000 r-xp /usr/lib/libelementary.so.1.7.99
b6c2a000 b6c30000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c31000 b6c35000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c39000 b6c3a000 r-xp /usr/lib/libjournal.so.0.1.0
b6c3b000 b6d83000 r-xp /usr/lib/libxml2.so.2.7.8
b6d8a000 b6d9d000 r-xp /lib/libresolv-2.13.so
b6da1000 b6dbe000 r-xp /lib/libz.so.1.2.5
b6dbf000 b6dc2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6dc3000 b6dc8000 r-xp /usr/lib/libffi.so.5.0.10
b6dc9000 b6dca000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dcc000 b6dd0000 r-xp /lib/libattr.so.1.1.0
b6dd1000 b6fe3000 r-xp /usr/lib/libcrypto.so.1.0.0
b6ffe000 b701f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7020000 b7048000 r-xp /lib/libm-2.13.so
b704a000 b70a5000 r-xp /usr/lib/libeina.so.1.7.99
b70a8000 b70b3000 r-xp /usr/lib/libvconf.so.0.2.45
b70b4000 b70b7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70b8000 b7106000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7107000 b7268000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b726c000 b7273000 r-xp /lib/librt-2.13.so
b7276000 b727d000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b727f000 b7299000 r-xp /lib/libgcc_s-4.6.4.so.1
b729a000 b72a2000 r-xp /lib/libcrypt-2.13.so
b72cb000 b72cf000 r-xp /lib/libcap.so.2.21
b72d0000 b72d2000 r-xp /usr/lib/libiri.so
b72d4000 b7300000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7301000 b7321000 r-xp /usr/lib/libecore.so.1.7.99
b7330000 b7339000 r-xp /usr/lib/libxdgmime.so.1.1.0
b733a000 b745d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b745e000 b7471000 r-xp /usr/lib/libail.so.0.1.0
b7473000 b7498000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7499000 b74a3000 r-xp /lib/libunwind.so.8.0.1
b74ad000 b761e000 r-xp /lib/libc-2.13.so
b7624000 b766e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b766f000 b7674000 r-xp /usr/lib/libbundle.so.0.1.22
b7675000 b7678000 r-xp /lib/libdl-2.13.so
b767b000 b7680000 r-xp /usr/lib/libsmack.so.1.0.0
b7681000 b7729000 r-xp /usr/lib/libsqlite3.so.0.8.6
b772c000 b7746000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7747000 b775e000 r-xp /lib/libpthread-2.13.so
b7762000 b7765000 r-xp /usr/lib/libdlog.so.0.0.0
b7766000 b7776000 r-xp /usr/lib/libaul.so.0.1.0
b7778000 b777e000 r-xp /usr/lib/libappcore-common.so.1.1
b777f000 b7784000 r-xp /usr/lib/libappcore-efl.so.1.1
b7786000 b778b000 r-xp /usr/lib/libsys-assert.so
b778e000 b77ac000 r-xp /lib/ld-2.13.so
b77ac000 b77ad000 r-xp [vdso]
b77af000 b77b6000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4675)
Call Stack Count: 18
 0: clicked_cb + 0x36 (0xb45cd986) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x1986
 1: evas_object_smart_callback_call + 0xe2 (0xb68a47d2) [/usr/lib/libevas.so.1] + 0x457d2
 2: (0xb6a89446) [/usr/lib/libelementary.so.1] + 0x6a446
 3: (0xb67e19a0) [/usr/lib/libedje.so.1] + 0x6a9a0
 4: (0xb67e8dd2) [/usr/lib/libedje.so.1] + 0x71dd2
 5: (0xb67e2a7c) [/usr/lib/libedje.so.1] + 0x6ba7c
 6: (0xb67e2faf) [/usr/lib/libedje.so.1] + 0x6bfaf
 7: (0xb67e3164) [/usr/lib/libedje.so.1] + 0x6c164
 8: (0xb730df32) [/usr/lib/libecore.so.1] + 0xcf32
 9: (0xb730a519) [/usr/lib/libecore.so.1] + 0x9519
10: (0xb730f47a) [/usr/lib/libecore.so.1] + 0xe47a
11: ecore_main_loop_begin + 0x3f (0xb730f9cf) [/usr/lib/libecore.so.1] + 0xe9cf
12: elm_run + 0x17 (0xb6b268a7) [/usr/lib/libelementary.so.1] + 0x1078a7
13: appcore_efl_main + 0x3d1 (0xb7781e91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
14: ui_app_main + 0x130 (0xb6c335f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
15: main + 0x293 (0xb45ccf53) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0xf53
16: (0xb77b25b1) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0xb77b25b1
17: __libc_start_main + 0xf3 (0xb74c60f3) [/lib/libc.so.6] + 0x190f3
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 1.0.0
Package Type: rpm
App Name: ph1
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
18): IjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAg93owydEvjSHNUn7QX8Qg45Vj4rICxbKi5PB
03-26 18:06:16.413+0900 D/rpm-installer( 4618): /iBhUqWraO6mTULZL95ZHKDBCrIQa4Om6UA0Cy6YtRz2Sc8fNWJHR9+GEI8bLgMNJuuYOCjbVZKR
03-26 18:06:16.413+0900 D/rpm-installer( 4618): Q6zFF0Yz/Jrm1WbiOLG6kuyX3i5tpHQ4cdEi0sQvLhGk6GR7gOydoDHXcrdRVXTHpTmN4dJlT5ca
03-26 18:06:16.413+0900 D/rpm-installer( 4618): UWG6fGV37mP80xcoW6As3xY+LiX84pAL3JOs08Rj85k6zM4LnRRryV3JfccMoPGQaPkpnw9xPM6e
03-26 18:06:16.413+0900 D/rpm-installer( 4618): Z6DBY4STsATLRRh4Ukcjke8iJfJNKy2J8EZiB86nsi8voTjAfD1Y25Zq1PFmWLz7j4OKB/rHIBcz
03-26 18:06:16.413+0900 D/rpm-installer( 4618): PQIDAQABoxowGDAJBgNVHRMEAjAAMAsGA1UdDwQEAwIHgDANBgkqhkiG9w0BAQsFAAOCAQEAUM8s
03-26 18:06:16.413+0900 D/rpm-installer( 4618): 3im2RY9U
03-26 18:06:16.413+0900 D/rpm-installer( 4618): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1298]
03-26 18:06:16.413+0900 D/rpm-installer( 4618): 
03-26 18:06:16.413+0900 D/rpm-installer( 4618): MIIDuzCCAqOgAwIBAgICL+cwDQYJKoZIhvcNAQELBQAwgY8xCzAJBgNVBAYTAktSMRQwEgYDVQQI
03-26 18:06:16.413+0900 D/rpm-installer( 4618): DAtTb3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25p
03-26 18:06:16.413+0900 D/rpm-installer( 4618): Y3MgQ28uLCBMdGQuMTIwMAYDVQQDDClTYW1zdW5nIFRpemVuIERFVkVMT1BFUiBQdWJsaWMgUm9v
03-26 18:06:16.413+0900 D/rpm-installer( 4618): dCBDbGFzczAeFw0xMzEyMzAxNTAxNDdaFw0yODEyMjYxNTAxNDdaMIGeMQswCQYDVQQGEwJLUjEU
03-26 18:06:16.413+0900 D/rpm-installer( 4618): MBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVs
03-26 18:06:16.413+0900 D/rpm-installer( 4618): ZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMTAwLgYDVQQDDCdTYW1zdW5nIFRp
03-26 18:06:16.413+0900 D/rpm-installer( 4618): emVuIERFVkVMT1BFUiBQdWJsaWMgQ0EgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEK
03-26 18:06:16.413+0900 D/rpm-installer( 4618): AoIBAQCkqW9d0zO5NFOc7u164DKe9Yx+yEgUnsbhnJasqHaqT71qaMxyCOjyysZi7gGycDcgmLcU
03-26 18:06:16.413+0900 D/rpm-installer( 4618): tr2wSMTGWPibK8SrJ8bV/J1cy9nTpljM3s+lbPIVVxZeufhJkU79tXImHLolERd0vui+rj0Xpd9O
03-26 18:06:16.413+0900 D/rpm-installer( 4618): zlyNTRt0+PWVT1taWcbfHL7pUD25hMkTc8C3bC+dUoT1/RhCkXgmUvIor3EnnU0rBtAl4qNtg5y1
03-26 18:06:16.413+0900 D/rpm-installer( 4618): 7RLT8dyicieAHCcW923YC/ngMZxnBjbL2Ht1RBUvrL6K3X5+l0VeF4qC3g7TKm/a/SGjq12ZD4sc
03-26 18:06:16.413+0900 D/rpm-installer( 4618): 7rglzjSNlTVSGag6/2WkqxE6HheEBWaloYOdauzwydFNAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8w
03-26 18:06:16.413+0900 D/rpm-installer( 4618): DQYJKoZI
03-26 18:06:16.473+0900 D/rpm-installer( 4618): rpm-installer.c: _ri_verify_sig_and_cert(1921) > cert_svc_verify() is done successfully. validity=[1]
03-26 18:06:16.473+0900 D/rpm-installer( 4618): rpm-installer.c: _ri_verify_sig_and_cert(1932) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/samsung_tizen_dev_public.pem]
03-26 18:06:16.483+0900 D/rpm-installer( 4618): rpm-installer.c: __ri_verify_file(407) > valid signature
03-26 18:06:16.483+0900 D/rpm-installer( 4618): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1268]
03-26 18:06:16.483+0900 D/rpm-installer( 4618): MIIDszCCApugAwIBAgIJALxYLI/Z7cqZMA0GCSqGSIb3DQEBCwUAMIGPMQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEyMDAGA1UEAwwpU2Ftc3VuZyBUaXplbiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MwHhcNMTMxMjMwMTUwMTQyWhcNMzMxMjI1MTUwMTQyWjCBjzELMAkGA1UEBhMCS1IxFDASBgNVBAgMC1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xMjAwBgNVBAMMKVNhbXN1bmcgVGl6ZW4gREVWRUxPUEVSIFB1YmxpYyBSb290IENsYXNzMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsBOg6dthhkQ5vY5QW2KXyMb2bwKqHLUqRj1GkdcOVWJA+rxBnRlfYVVBJv9MCecrLkieriWfHB3Tcn9fIUnGtSzj2X7An5Qg05toNkjuS7B73Pb+eHZ2vEFNmFf+FQBc6KzCg+fSBa63BZg/lQg+l97gSKE1KFzU8D8INWJd/Yn6Uespvmcbyp3nlKakfleVdEsYOQ3HTevPfnoClRYsCI4R5/rFM4h6GzO2X8IEDhLgMc/Q8VWH/CoRkGwww7C//ofutdNs2WCF8FISyiSJq+sDXHlyGXKtZ+7ArKdLpe3xOZGGY2NJOV7H1v0vtJZeJSFPcoVd5csKgURu9v/7twIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBY+gZZPQ6MYkIrYB6JmaorVncOwy
03-26 18:06:16.483+0900 D/rpm-installer( 4618): rpm-installer.c: _ri_verify_sig_and_cert(1956) > cert_svc_get_visibility() returns visibility=[64]
03-26 18:06:16.483+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_verify_signatures(895) > _ri_verify_sig_and_cert() succeed, path=[/opt/usr/apps/org.example.ph1/signature1.xml]
03-26 18:06:16.483+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_package_reinstall(3345) > signature and certificate verifying success
03-26 18:06:16.493+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2276): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/DATA_PROVIDER_MASTER( 2276): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ph1] 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2282): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/ADD_VIEWER( 2261): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.ph1] 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/W_HOME  ( 2261): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.ph1 key:install_percent val:60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/APPS    ( 2261): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.ph1
03-26 18:06:16.493+0900 D/APPS    ( 2261): pkgmgr.c: _install_percent(469) >  package(org.example.ph1) with 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 60
03-26 18:06:16.493+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[60]
03-26 18:06:16.493+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.493+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 2
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 2
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 2
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 2
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 2
03-26 18:06:16.493+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 17 1
03-26 18:06:16.503+0900 E/PKGMGR_CERT( 4618): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.ph1/shared], errno=[2][No such file or directory]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.ph1/shared]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.ph1/shared/res]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.ph1/tizen-manifest.xml]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.ph1/author-signature.xml]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.ph1/signature1.xml]
03-26 18:06:16.503+0900 E/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.ph1.xml]
03-26 18:06:16.503+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.ph1/shared/data])
03-26 18:06:16.533+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_unregister_package(84) > [smack] app_uninstall(org.example.ph1), result=[0]
03-26 18:06:16.543+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.ph1), result=[0]
03-26 18:06:16.553+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1, 5, _), result=[0]
03-26 18:06:16.553+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/shared, 5, _), result=[0]
03-26 18:06:16.553+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/shared/res, 5, _), result=[0]
03-26 18:06:16.573+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/shared/data, 2), result=[0]
03-26 18:06:16.573+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
03-26 18:06:16.573+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [JHSVb#Y5zvwR9TFyGGLtiE13R+Q=] for shared/trusted.
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/shared/trusted, 1, JHSVb#Y5zvwR9TFyGGLtiE13R+Q=), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/bin, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/data, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/lib, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/res, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/cache, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/tizen-manifest.xml, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/author-signature.xml, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/usr/apps/org.example.ph1/signature1.xml, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/share/packages/org.example.ph1.xml, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/storage/sdcard/apps/org.example.ph1, 5, _), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/storage/sdcard/apps/org.example.ph1/data, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/storage/sdcard/apps/org.example.ph1/cache, 0, org.example.ph1), result=[0]
03-26 18:06:16.593+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.ph1, /opt/storage/sdcard/apps/org.example.ph1/shared, 5, _), result=[0]
03-26 18:06:16.613+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ph1, /opt/storage/sdcard/apps/org.example.ph1/shared/data, 2), result=[0]
03-26 18:06:16.613+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-26 18:06:16.613+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.ph1, 7), result=[0]
03-26 18:06:16.633+0900 D/rpm-installer( 4618): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-26 18:06:16.633+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_package_reinstall(3437) > #permission applying success.
03-26 18:06:16.633+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2276): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/DATA_PROVIDER_MASTER( 2276): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ph1] 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2282): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/ADD_VIEWER( 2261): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.ph1] 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/W_HOME  ( 2261): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.ph1 key:install_percent val:100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/APPS    ( 2261): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.ph1
03-26 18:06:16.633+0900 D/APPS    ( 2261): pkgmgr.c: _install_percent(469) >  package(org.example.ph1) with 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.633+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / install_percent / 100
03-26 18:06:16.633+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[install_percent] val[100]
03-26 18:06:16.633+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.633+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/rpm-installer( 4618): coretpk-installer.c: _coretpk_installer_package_reinstall(3468) > [#]end : _coretpk_installer_package_reinstall
03-26 18:06:16.643+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2276): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/DATA_PROVIDER_MASTER( 2276): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.ph1] ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2282): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2282): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/ADD_VIEWER( 2261): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.ph1] ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/W_HOME  ( 2261): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.ph1 key:end val:ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/APPS    ( 2261): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.ph1
03-26 18:06:16.643+0900 D/APPS    ( 2261): pkgmgr.c: _end(651) >  Package(org.example.ph1) : key(update) - val(ok)
03-26 18:06:16.643+0900 D/APPS    ( 2261): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.ph1]
03-26 18:06:16.643+0900 D/APPS    ( 2261): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.ph1]'s item object
03-26 18:06:16.643+0900 D/APPS    ( 2261): db.c: apps_db_remove_item(404) >  Remove the item[org.example.ph1]
03-26 18:06:16.643+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.643+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.643+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.643+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.653+0900 D/APPS    ( 2261): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.ph1], name[ph1]
03-26 18:06:16.653+0900 D/APPS    ( 2261): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.ph1]
03-26 18:06:16.653+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-26 18:06:16.653+0900 D/DATA_PROVIDER_MASTER( 2276): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-26 18:06:16.653+0900 D/BADGE   ( 2276): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.ph1'], count[0]
03-26 18:06:16.653+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 93 bytes
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2276, fd: -1
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2276), fd: -1
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 31 (recv_fd: -1)
03-26 18:06:16.663+0900 D/APPS    ( 2261): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.ph1]
03-26 18:06:16.663+0900 D/COM_CORE( 2276): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-26 18:06:16.663+0900 E/DATA_PROVIDER_MASTER( 2276): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8e4bab0 is terminated (NIL packet)
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 93 bytes
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-26 18:06:16.663+0900 D/BADGE   ( 2276): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.ph1'], count[0]
03-26 18:06:16.663+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2276, fd: -1
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2276), fd: -1
03-26 18:06:16.663+0900 D/COM_CORE( 2261): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 31 (recv_fd: -1)
03-26 18:06:16.673+0900 E/DATA_PROVIDER_MASTER( 2276): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-26 18:06:16.673+0900 D/COM_CORE( 2276): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-26 18:06:16.673+0900 D/DATA_PROVIDER_MASTER( 2276): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8e4d7a0 is terminated (NIL packet)
03-26 18:06:16.673+0900 D/DATA_PROVIDER_MASTER( 2276): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-26 18:06:16.673+0900 D/APPS    ( 2261): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.ph1], name[ph1]
03-26 18:06:16.673+0900 D/APPS    ( 2261): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-26 18:06:16.673+0900 D/BADGE   ( 2261): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.ph1'], count[0]
03-26 18:06:16.673+0900 D/APPS    ( 2261): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-26 18:06:16.673+0900 D/APPS    ( 2261): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.label]'s ordering : 1
03-26 18:06:16.673+0900 D/APPS    ( 2261): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.hello]'s ordering : 2
03-26 18:06:16.673+0900 D/APPS    ( 2261): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.ph1]'s ordering : 3
03-26 18:06:16.673+0900 D/APPS    ( 2261): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-26 18:06:16.683+0900 D/rpm-installer( 4618): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-26 18:06:16.683+0900 D/rpm-installer( 4618): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-26 18:06:16.683+0900 D/rpm-installer( 4618): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-26 18:06:16.683+0900 D/PKGMGR_SERVER( 4617): pkgmgr-server.c: sighandler(326) > child exit [4618]
03-26 18:06:16.683+0900 D/PKGMGR_SERVER( 4617): pkgmgr-server.c: sighandler(341) > child NORMAL exit [4618]
03-26 18:06:16.683+0900 D/PKGMGR  ( 2158): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.ph1_-34356868 / coretpk / org.example.ph1 / end / ok
03-26 18:06:16.683+0900 D/PKGMGR  ( 2158): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.ph1_-34356868] pkg_type[coretpk] pkgid[org.example.ph1]key[end] val[ok]
03-26 18:06:16.683+0900 D/AUL_AMD ( 2158): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.ph1), key(end), value(ok)
03-26 18:06:16.683+0900 D/AUL_AMD ( 2158): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(update), value(ok)
03-26 18:06:16.683+0900 D/AUL_AMD ( 2158): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-26 18:06:16.683+0900 D/AUL_AMD ( 2158): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.ph1, comp:ui, type:rpm
03-26 18:06:16.683+0900 D/PKGMGR  ( 2158): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.683+0900 D/PKGMGR  ( 2158): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:16.693+0900 D/APPS    ( 2261): db.c: apps_db_update_item(374) >  Update the item[org.example.label:1]
03-26 18:06:16.703+0900 D/APPS    ( 2261): db.c: apps_db_update_item(374) >  Update the item[org.example.hello:2]
03-26 18:06:16.703+0900 D/APPS    ( 2261): db.c: apps_db_insert_item(345) >  Insert the item[org.example.ph1:3]
03-26 18:06:16.713+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-26 18:06:16.713+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-26 18:06:18.993+0900 D/PKGMGR_SERVER( 4617): pkgmgr-server.c: exit_server(724) > exit_server Start
03-26 18:06:18.993+0900 D/PKGMGR_SERVER( 4617): pkgmgr-server.c: main(1516) > Quit main loop.
03-26 18:06:18.993+0900 D/PKGMGR_SERVER( 4617): pkgmgr-server.c: main(1524) > package manager server terminated.
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_request.c: __request_handler(495) > __request_handler: 0
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.ph1
03-26 18:06:19.763+0900 D/AUL     ( 2158): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 4672, pid = 4674
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_launch.c: _start_app(1785) > process_pool: false
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.ph1
03-26 18:06:19.763+0900 D/AUL_AMD ( 2158): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-26 18:06:19.763+0900 D/AUL     ( 2158): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-26 18:06:19.763+0900 D/AUL_PAD ( 2192): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.ph1
03-26 18:06:19.763+0900 D/AUL_PAD ( 2192): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-26 18:06:19.763+0900 D/AUL_PAD ( 2192): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4675 /opt/usr/apps/org.example.ph1/bin/ph1
03-26 18:06:19.763+0900 D/AUL_PAD ( 2192): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-26 18:06:19.763+0900 D/AUL_PAD ( 4675): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-26 18:06:19.763+0900 D/AUL_PAD ( 4675): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-26 18:06:19.763+0900 D/AUL_PAD ( 4675): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.ph1 / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ph1/bin/ph1 
03-26 18:06:19.773+0900 D/AUL_PAD ( 4675): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-26 18:06:19.773+0900 D/AUL_PAD ( 4675): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ph1/bin/ph1##
03-26 18:06:19.773+0900 D/AUL_PAD ( 4675): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-26 18:06:19.773+0900 D/AUL_PAD ( 4675): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-26 18:06:19.773+0900 D/LAUNCH  ( 4675): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.ph1/bin/ph1:Platform:launchpad:done]
03-26 18:06:19.783+0900 I/CAPI_APPFW_APPLICATION( 4675): app_main.c: ui_app_main(701) > app_efl_main
03-26 18:06:19.783+0900 D/LAUNCH  ( 4675): appcore-efl.c: appcore_efl_main(1571) > [ph1:Application:main:done]
03-26 18:06:19.823+0900 D/APP_CORE( 4675): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-26 18:06:19.823+0900 D/AUL     ( 4675): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4675 is org.example.ph1
03-26 18:06:19.823+0900 D/APP_CORE( 4675): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.ph1/res/locale
03-26 18:06:19.823+0900 D/APP_CORE( 4675): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-26 18:06:19.823+0900 D/AUL     ( 4675): app_sock.c: __create_server_sock(136) > pg path - already exists
03-26 18:06:19.823+0900 D/LAUNCH  ( 4675): appcore-efl.c: __before_loop(1035) > [ph1:Platform:appcore_init:done]
03-26 18:06:19.823+0900 I/CAPI_APPFW_APPLICATION( 4675): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-26 18:06:19.873+0900 D/AUL_PAD ( 2192): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-26 18:06:19.873+0900 D/AUL_PAD ( 2192): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-26 18:06:19.873+0900 D/AUL_PAD ( 2192): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-26 18:06:19.873+0900 D/AUL     ( 2158): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-26 18:06:19.873+0900 E/AUL     ( 2158): simple_util.c: __trm_app_info_send_socket(264) > access
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2158
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.ph1, pid 4675, type 4 
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.ph1, 4675
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.ph1 with pkgname
03-26 18:06:19.873+0900 E/RESOURCED( 2349): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 386
03-26 18:06:19.873+0900 D/RESOURCED( 2349): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-26 18:06:19.873+0900 E/EFL     ( 4675): eina_module<4675> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-26 18:06:19.903+0900 E/EFL     ( 4675): elementary<4675> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-26 18:06:19.903+0900 E/EFL     ( 4675): eina_module<4675> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-26 18:06:19.913+0900 D/LAUNCH  ( 4675): appcore-efl.c: __before_loop(1047) > [ph1:Application:create:done]
03-26 18:06:19.933+0900 D/APP_CORE( 4675): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-26 18:06:19.933+0900 D/APP_CORE( 4675): appcore.c: __aul_handler(423) > [APP 4675]     AUL event: AUL_START
03-26 18:06:19.933+0900 D/APP_CORE( 4675): appcore-efl.c: __do_app(470) > [APP 4675] Event: RESET State: CREATED
03-26 18:06:19.933+0900 D/APP_CORE( 4675): appcore-efl.c: __do_app(496) > [APP 4675] RESET
03-26 18:06:19.933+0900 D/LAUNCH  ( 4675): appcore-efl.c: __do_app(498) > [ph1:Application:reset:start]
03-26 18:06:19.933+0900 I/CAPI_APPFW_APPLICATION( 4675): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-26 18:06:19.933+0900 D/APP_SVC ( 4675): appsvc.c: __set_bundle(161) > __set_bundle
03-26 18:06:19.933+0900 D/LAUNCH  ( 4675): appcore-efl.c: __do_app(501) > [ph1:Application:reset:done]
03-26 18:06:19.933+0900 I/APP_CORE( 4675): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-26 18:06:19.933+0900 I/APP_CORE( 4675): appcore-efl.c: __do_app(509) > [APP 4675] Initial Launching, call the resume_cb
03-26 18:06:19.933+0900 I/CAPI_APPFW_APPLICATION( 4675): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-26 18:06:19.933+0900 D/APP_CORE( 4675): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-26 18:06:19.943+0900 E/W_HOME  ( 2261): main.c: _window_focus_out_cb(885) > win[27262980], ev->win[27262986]
03-26 18:06:19.943+0900 D/APPS    ( 2261): apps_main.c: _window_focus_out_cb(308) >  focus out
03-26 18:06:19.943+0900 E/W_HOME  ( 2261): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-26 18:06:19.943+0900 D/APPS    ( 2261): apps_main.c: apps_main_pause(656) >  Pause starts
03-26 18:06:19.943+0900 D/APPS    ( 2261): apps_main.c: apps_main_pause(676) >  Pause done
03-26 18:06:20.003+0900 D/APP_CORE( 4675): appcore.c: __prt_ltime(183) > [APP 4675] first idle after reset: 244 msec
03-26 18:06:20.003+0900 D/APP_CORE( 4675): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:a00002
03-26 18:06:20.003+0900 D/APP_CORE( 4675): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:a00002
03-26 18:06:20.223+0900 D/APP_CORE( 4675): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:a00002 fully_obscured 0
03-26 18:06:20.223+0900 D/APP_CORE( 4675): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-26 18:06:20.223+0900 D/APP_CORE( 4675): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-26 18:06:20.223+0900 D/APP_CORE( 4675): appcore-efl.c: __do_app(470) > [APP 4675] Event: RESUME State: RUNNING
03-26 18:06:20.223+0900 D/LAUNCH  ( 4675): appcore-efl.c: __do_app(557) > [ph1:Application:resume:start]
03-26 18:06:20.223+0900 D/LAUNCH  ( 4675): appcore-efl.c: __do_app(567) > [ph1:Application:resume:done]
03-26 18:06:20.223+0900 D/LAUNCH  ( 4675): appcore-efl.c: __do_app(569) > [ph1:Application:Launching:done]
03-26 18:06:20.223+0900 D/APP_CORE( 4675): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-26 18:06:20.223+0900 E/APP_CORE( 4675): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1a0000a fully_obscured 1
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __do_app(470) > [APP 2261] Event: PAUSE State: RUNNING
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __do_app(538) > [APP 2261] PAUSE
03-26 18:06:20.223+0900 I/CAPI_APPFW_APPLICATION( 2261): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-26 18:06:20.223+0900 D/W_HOME  ( 2261): main.c: _pause_cb(600) > Paused
03-26 18:06:20.223+0900 E/W_HOME  ( 2261): main.c: _pause_cb(603) > paused already
03-26 18:06:20.223+0900 D/APP_CORE( 2261): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-26 18:06:20.223+0900 E/APP_CORE( 2261): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-26 18:06:20.223+0900 D/RESOURCED( 2349): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2261, type = 2
03-26 18:06:20.243+0900 D/RESOURCED( 2349): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4675, type = 0
03-26 18:06:20.243+0900 D/RESOURCED( 2349): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4675
03-26 18:06:20.243+0900 I/RESOURCED( 2349): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4675, oom : 200
03-26 18:06:20.243+0900 E/RESOURCED( 2349): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-26 18:06:20.243+0900 D/AUL_AMD ( 2158): amd_launch.c: __e17_status_handler(1911) > pid(4675) status(3)
03-26 18:06:20.833+0900 D/APP_CORE( 4675): appcore-rotation.c: __changed_cb(123) > [APP 4675] Rotation: 0 -> 1
03-26 18:06:20.833+0900 D/APP_CORE( 4675): appcore-rotation.c: __changed_cb(126) > [APP 4675] Rotation: 0 -> 1
03-26 18:06:20.833+0900 I/CAPI_APPFW_APPLICATION( 4675): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
03-26 18:06:20.883+0900 D/AUL_AMD ( 2158): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.ph1 /opt/usr/apps/org.example.ph1/bin/ph1
03-26 18:06:20.883+0900 D/RUA     ( 2158): rua.c: rua_add_history(179) > rua_add_history start
03-26 18:06:20.883+0900 D/RUA     ( 2158): rua.c: rua_add_history(247) > rua_add_history ok
03-26 18:06:22.673+0900 I/GESTURE ( 1981): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-26 18:06:22.723+0900 D/EFL     ( 4675): ecore_x<4675> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=3297678 button=1
03-26 18:06:22.763+0900 D/EFL     ( 4675): ecore_x<4675> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=3297752 button=1
03-26 18:06:22.763+0900 E/EFL     ( 4675): eina_module<4675> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-26 18:06:22.883+0900 W/CRASH_MANAGER( 4680): worker.c: worker_job(1189) > 1104675706831145898318
