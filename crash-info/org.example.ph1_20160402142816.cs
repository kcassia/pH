S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 11010
Date: 2016-04-02 14:28:16+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11010, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x44a3c0b0, r5   = 0x44a29cb8
r6   = 0x4193cd38, r7   = 0xbecd32a0
r8   = 0x00000000, r9   = 0x44a36a40
r10  = 0x44a3c468, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbecd3248
lr   = 0x00000000, pc   = 0x4155fdf0
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     21080 KB
Buffers:     42728 KB
Cached:     149256 KB
VmPeak:      89492 KB
VmSize:      87456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23196 KB
VmRSS:       23192 KB
VmData:      26256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24952 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11010 TID = 11010
11010 11192 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41530000 41534000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4153c000 41544000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 41561000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41569000 41571000 r-xp /usr/lib/libmdm-common.so.1.0.89
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 4197e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41986000 419a7000 r-xp /usr/lib/libefl-extension.so.0.1.0
419af000 419c6000 r-xp /usr/lib/libnetwork.so.0.0.0
419ce000 419d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
419db000 419ed000 r-xp /usr/lib/libefl-assist.so.0.1.0
419f5000 41aad000 r-xp /usr/lib/libcairo.so.2.11200.14
41ab8000 41ae9000 r-xp /usr/lib/libmdm.so.1.1.85
41af1000 41b03000 r-xp /usr/lib/libtts.so
41b0b000 41b2c000 r-xp /usr/lib/libui-extension.so.0.1.0
41b35000 41b3c000 r-xp /usr/lib/libtbm.so.1.0.0
41b44000 41b52000 r-xp /usr/lib/libGLESv2.so.2.0
41b5b000 41b5c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41b65000 41b6b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b73000 41b76000 r-xp /usr/lib/libEGL.so.1.4
41b7e000 41cbb000 r-xp /usr/lib/libicui18n.so.51.1
41ccb000 41daf000 r-xp /usr/lib/libicuuc.so.51.1
41dc4000 41dc7000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41dcf000 41dd7000 r-xp /usr/lib/libdrm.so.2.4.0
43366000 4336b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43374000 43379000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43381000 43383000 r-xp /usr/lib/libdri2.so.0.0.0
4338b000 433ac000 r-xp /usr/lib/libexif.so.12.3.3
433bf000 433c4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433cc000 43496000 r-xp /usr/lib/libCOREGL.so.4.0
437d9000 437e4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
437ed000 437f1000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
437f9000 43810000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4381d000 4381f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44028000 44827000 rwxp [stack:11192]
448c5000 448c6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448d5000 448da000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
448e2000 448f2000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
44db0000 44db1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44dce000 44dd5000 r-xp /usr/lib/libfeedback.so.0.1.4
44dde000 44ddf000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44de7000 44de9000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44df1000 44df8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45000000 4500a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45012000 45028000 r-xp /usr/lib/libmmfsound.so.0.1.0
4503a000 4503f000 r-xp /usr/lib/libmmfsession.so.0.0.0
45047000 45051000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4505d000 45061000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4506a000 45080000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45089000 4508e000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45096000 45099000 r-xp /usr/lib/libpulse-simple.so.0.0.4
450a1000 450d9000 r-xp /usr/lib/libpulse.so.0.16.2
450da000 450dd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
450e5000 450f2000 r-xp /usr/lib/libail.so.0.1.0
4531d000 4537e000 r-xp /usr/lib/libasound.so.2.0.0
45388000 45398000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
453b9000 453c1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
453d0000 453d3000 r-xp /usr/lib/libcompress.so.0.2.0
453db000 453e0000 r-xp /usr/lib/libjson.so.0.0.1
453e8000 45430000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45431000 45474000 r-xp /usr/lib/libsndfile.so.1.0.25
45481000 454a3000 r-xp /usr/lib/libvorbis.so.0.4.3
454ab000 454af000 r-xp /usr/lib/libogg.so.0.7.1
becb3000 becd4000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11010)
Call Stack Count: 1
 0: create_third_page + 0x1b (0x4155fdf0) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x2df0
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
075): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
04-02 14:27:40.183+0900 W/WAKEUP-SERVICE( 1075): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
04-02 14:27:40.183+0900 W/WAKEUP-SERVICE( 1075): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-02 14:27:40.188+0900 I/TIZEN_N_SOUND_MANAGER( 1075): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
04-02 14:27:40.193+0900 W/TIZEN_N_SOUND_MANAGER( 1075): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-02 14:27:40.193+0900 I/TIZEN_N_SOUND_MANAGER( 1075): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
04-02 14:27:40.198+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:27:40.203+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:27:40.203+0900 I/TIZEN_N_SOUND_MANAGER( 1075): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-02 14:27:40.203+0900 W/TIZEN_N_SOUND_MANAGER( 1075): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-02 14:27:40.203+0900 W/WAKEUP-SERVICE( 1075): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
04-02 14:27:40.203+0900 I/HIGEAR  ( 1075): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
04-02 14:27:40.203+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_10min_precaution_millisec error
04-02 14:27:40.208+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:27:40.208+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:27:40.208+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_before_10min_precaution_millisec error
04-02 14:27:40.223+0900 W/APPS    (  731): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:27:40.938+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:40.943+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:27:40.943+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [true][0m
04-02 14:27:40.948+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:27:40.973+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 731
04-02 14:27:40.988+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1107]   [MUSIC_PLAYER_EVENT][0m
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:27:40.993+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:27:40.998+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:41.003+0900 W/W_HOME  (  731): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
04-02 14:27:41.003+0900 E/W_HOME  (  731): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-02 14:27:41.008+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1107]   [MUSIC_PLAYER_EVENT][0m
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:27:41.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:27:41.018+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:41.018+0900 W/W_HOME  (  731): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
04-02 14:27:41.018+0900 E/W_HOME  (  731): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-02 14:27:41.033+0900 I/efl-extension(  731): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
04-02 14:27:41.033+0900 I/efl-extension(  731): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x47890470, elm_layout, time_stamp : 7250171
04-02 14:27:41.033+0900 W/APPS    (  731): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[20]
04-02 14:27:41.033+0900 W/APPS    (  731): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
04-02 14:27:41.038+0900 I/efl-extension( 1175): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
04-02 14:27:41.258+0900 W/APPS    (  731): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
04-02 14:27:45.543+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
04-02 14:27:45.548+0900 E/EFL     (  731): evas_main<731> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7254683 button=1 downs=1
04-02 14:27:45.548+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [157, 197]
04-02 14:27:45.618+0900 E/EFL     (  731): evas_main<731> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7254742 button=1 downs=0
04-02 14:27:45.623+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [157, 197]->[160, 197]
04-02 14:27:45.623+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,18]
04-02 14:27:45.628+0900 E/APPS    (  731): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-02 14:27:45.628+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(410) >  item(ph1) launched, open(0)
04-02 14:27:45.638+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 0
04-02 14:27:45.638+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(1702) > caller pid : 731
04-02 14:27:45.638+0900 I/AUL_AMD (  473): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
04-02 14:27:45.653+0900 E/RESOURCED(  475): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
04-02 14:27:45.653+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
04-02 14:27:45.658+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(2080) > pad pid(-5)
04-02 14:27:45.663+0900 W/AUL_PAD ( 1174): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
04-02 14:27:45.663+0900 W/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(272) > Check app launching
04-02 14:27:45.703+0900 I/efl-extension(11010): efl_extension.c: eext_mod_init(40) > Init
04-02 14:27:45.703+0900 I/UXT     (11010): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
04-02 14:27:45.703+0900 I/CAPI_APPFW_APPLICATION(11010): app_main.c: ui_app_main(704) > app_efl_main
04-02 14:27:45.708+0900 I/CAPI_APPFW_APPLICATION(11010): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-02 14:27:45.748+0900 E/TBM     (11010): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
04-02 14:27:45.768+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:27:45.768+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
04-02 14:27:45.798+0900 E/EFL     (11010): <11010> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
04-02 14:27:45.808+0900 E/EFL     (11010): <11010> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:27:45.808+0900 E/EFL     (11010): <11010> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:27:45.808+0900 E/EFL     (11010): <11010> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:27:45.808+0900 E/EFL     (11010): <11010> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:27:45.853+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03400002)
04-02 14:27:45.873+0900 I/APP_CORE(11010): appcore-efl.c: __do_app(429) > [APP 11010] Event: RESET State: CREATED
04-02 14:27:45.873+0900 I/CAPI_APPFW_APPLICATION(11010): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-02 14:27:45.893+0900 I/APP_CORE(11010): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
04-02 14:27:45.893+0900 I/APP_CORE(11010): appcore-efl.c: __do_app(474) > [APP 11010] Initial Launching, call the resume_cb
04-02 14:27:45.893+0900 I/CAPI_APPFW_APPLICATION(11010): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-02 14:27:45.903+0900 I/MALI    (  731): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1460] swap changed from sync to async
04-02 14:27:45.903+0900 W/APP_CORE(11010): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
04-02 14:27:45.913+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:27:45.913+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.913+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.913+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.913+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:27:45.918+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:27:45.918+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:27:45.963+0900 I/APP_CORE(11010): appcore-efl.c: __do_app(429) > [APP 11010] Event: RESUME State: RUNNING
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.978+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
04-02 14:27:45.978+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
04-02 14:27:45.978+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:27:45.978+0900 W/W_HOME  (  731): main.c: _appcore_pause_cb(690) > appcore pause
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.978+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:27:45.978+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47890470
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47890470, elm_layout, func : 0x4004b469
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47890470, activated : 1
04-02 14:27:45.978+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:27:45.978+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:27:45.978+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:27:45.988+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:27:45.988+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:27:45.988+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [false][0m
04-02 14:27:46.003+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:27:46.003+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:27:46.048+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
04-02 14:27:46.048+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:27:46.063+0900 W/APPS    (  731): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
04-02 14:27:46.358+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:27:46.503+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:27:46.883+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:27:46.908+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11010
04-02 14:27:46.913+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 12
04-02 14:27:46.938+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7256073 button=1 downs=1
04-02 14:27:46.998+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7256136 button=1 downs=0
04-02 14:27:47.233+0900 I/AUL_PAD (11155): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
04-02 14:27:51.008+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:27:55.803+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7264940 button=1 downs=1
04-02 14:27:55.838+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7264976 button=1 downs=0
04-02 14:27:56.503+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:27:56.503+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:27:56.503+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:27:56.503+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:27:56.503+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:27:56.503+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:27:56.533+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:true] pos=0[0m
04-02 14:27:56.563+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:27:56.563+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:27:56.608+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:27:56.613+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
04-02 14:27:56.683+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:27:56.733+0900 E/AUL_AMD (  473): amd_appinfo.c: appinfo_get_value(999) > appinfo get value: Invalid argument, 9
04-02 14:27:57.078+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:27:57.083+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:27:58.023+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7267151 button=1 downs=1
04-02 14:27:58.083+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7267220 button=1 downs=0
04-02 14:27:58.838+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7267976 button=1 downs=1
04-02 14:27:58.913+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7268052 button=1 downs=0
04-02 14:27:58.918+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:27:58.948+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:27:58.953+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:27:58.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:27:58.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:27:58.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:27:58.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:27:58.978+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:27:59.053+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:27:59.053+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:27:59.088+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:27:59.088+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:27:59.123+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:27:59.123+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:27:59.138+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:27:59.453+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:27:59.463+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7268602 button=1 downs=1
04-02 14:27:59.488+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7268624 button=1 downs=0
04-02 14:27:59.493+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:27:59.973+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-02 14:27:59.978+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-02 14:27:59.983+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : pedometer_inactive_period error
04-02 14:27:59.993+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:27:59.998+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:27:59.998+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_10min_precaution_millisec error
04-02 14:28:00.008+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:28:00.013+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:28:00.013+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_before_10min_precaution_millisec error
04-02 14:28:00.683+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:00.708+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:28:00.813+0900 W/APPS    (  731): apps_main.c: _time_changed_cb(295) >  date : 2->2
04-02 14:28:00.953+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:00.973+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:28:01.203+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:01.218+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:28:01.588+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7270722 button=1 downs=1
04-02 14:28:01.663+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7270804 button=1 downs=0
04-02 14:28:01.668+0900 E/IMMODULE(11010): isf_imf_context.cpp: isf_imf_context_filter_event(2158) > Can't show IME because there is no focus. ctx : 0x4193e1a0
04-02 14:28:02.208+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7271340 button=1 downs=1
04-02 14:28:02.298+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7271432 button=1 downs=0
04-02 14:28:02.298+0900 E/IMMODULE(11010): isf_imf_context.cpp: isf_imf_context_filter_event(2158) > Can't show IME because there is no focus. ctx : 0x4193e1a0
04-02 14:28:02.808+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7271946 button=1 downs=1
04-02 14:28:02.833+0900 E/SHealth_Common( 1027): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
04-02 14:28:02.898+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7272034 button=1 downs=0
04-02 14:28:02.903+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:02.933+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:28:02.938+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:28:02.948+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:28:02.948+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:28:02.948+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:28:02.948+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:28:02.948+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:28:02.988+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:28:02.988+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:03.018+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:28:03.018+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:28:03.058+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:28:03.058+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:28:03.083+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:28:03.443+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 80 -> 79 1459574884 90
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 1139 195 1500
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 0 0 974
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 1249 734 1645
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 557 5 733
04-02 14:28:04.408+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 743 15 978
04-02 14:28:04.513+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:04.543+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:28:04.658+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:04.668+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:28:05.013+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:05.038+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:28:06.553+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7275686 button=1 downs=1
04-02 14:28:06.658+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7275796 button=1 downs=0
04-02 14:28:06.663+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:06.693+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:28:06.698+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:28:06.713+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:28:06.713+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:28:06.713+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:28:06.713+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:28:06.718+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:28:06.783+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:28:06.783+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:06.818+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:28:06.818+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:28:06.863+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:28:06.863+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:28:06.883+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:28:07.198+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:28:07.623+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:07.668+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:28:07.798+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:07.818+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:28:08.218+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7277355 button=1 downs=1
04-02 14:28:08.308+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7277447 button=1 downs=0
04-02 14:28:08.313+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:08.343+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:28:08.343+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:28:08.358+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:28:08.358+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:28:08.358+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:28:08.358+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:28:08.358+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:28:08.398+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:28:08.398+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:08.433+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:28:08.433+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:28:08.483+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:28:08.483+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:28:08.508+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:28:08.848+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:28:09.193+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:09.223+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:28:09.308+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:09.328+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:28:09.593+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:28:09.613+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:28:09.968+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [65293][0m
04-02 14:28:10.683+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:28:10.713+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:28:10.783+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_clear(121) > [0;31mrotary_input_clear[0m
04-02 14:28:10.798+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
04-02 14:28:10.798+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
04-02 14:28:10.798+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
04-02 14:28:10.798+0900 E/ISE_MULTI(  995): rotary_input.cpp: destroy_rotary_input_layout(622) > [0;31mdestroy_rotary_input_layout[0m
04-02 14:28:10.798+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:28:11.428+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:28:11.953+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
04-02 14:28:11.953+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
04-02 14:28:15.673+0900 E/EFL     (11010): evas_main<11010> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7284807 button=1 downs=1
04-02 14:28:15.783+0900 E/EFL     (11010): evas_main<11010> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7284921 button=1 downs=0
04-02 14:28:15.793+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:true][0m
04-02 14:28:15.818+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:28:15.823+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:28:16.038+0900 D/IP      (11010): 192.168.43.165
04-02 14:28:16.038+0900 D/PORT    (11010): 7777
04-02 14:28:16.328+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:28:16.438+0900 W/CRASH_MANAGER(11293): worker.c: worker_job(1199) > 1111010706831145957489
