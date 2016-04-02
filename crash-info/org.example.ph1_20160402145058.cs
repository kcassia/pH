S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 16001
Date: 2016-04-02 14:50:58+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16001, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x449641a8, r5   = 0x44c95f90
r6   = 0x44c78340, r7   = 0xbea15320
r8   = 0x00000000, r9   = 0x44934c70
r10  = 0x4495a3e0, fp   = 0x00000001
ip   = 0x44c95f90, sp   = 0xbea152c8
lr   = 0x00000000, pc   = 0x4145fe38
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     22004 KB
Buffers:     43584 KB
Cached:     139324 KB
VmPeak:      87516 KB
VmSize:      85480 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21852 KB
VmRSS:       21848 KB
VmData:      25456 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24952 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16001 TID = 16001
16001 16255 

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
41430000 41434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4143c000 41444000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 41461000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41469000 41471000 r-xp /usr/lib/libmdm-common.so.1.0.89
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 4177e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41786000 417a7000 r-xp /usr/lib/libefl-extension.so.0.1.0
417af000 417c6000 r-xp /usr/lib/libnetwork.so.0.0.0
417ce000 417d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417db000 417ed000 r-xp /usr/lib/libefl-assist.so.0.1.0
417f5000 418ad000 r-xp /usr/lib/libcairo.so.2.11200.14
418b8000 418e9000 r-xp /usr/lib/libmdm.so.1.1.85
418f1000 41903000 r-xp /usr/lib/libtts.so
4190b000 4192c000 r-xp /usr/lib/libui-extension.so.0.1.0
41935000 4193c000 r-xp /usr/lib/libtbm.so.1.0.0
41944000 41952000 r-xp /usr/lib/libGLESv2.so.2.0
4195b000 4195c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41965000 4196b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41973000 41976000 r-xp /usr/lib/libEGL.so.1.4
4197e000 41abb000 r-xp /usr/lib/libicui18n.so.51.1
41acb000 41baf000 r-xp /usr/lib/libicuuc.so.51.1
41bc4000 41bc7000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41bcf000 41bd7000 r-xp /usr/lib/libdrm.so.2.4.0
41bdf000 41be4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bed000 41bf2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bfa000 41bfc000 r-xp /usr/lib/libdri2.so.0.0.0
41c04000 41c25000 r-xp /usr/lib/libexif.so.12.3.3
41c38000 41c3d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c45000 41d0f000 r-xp /usr/lib/libCOREGL.so.4.0
41f21000 41f2c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41f35000 41f39000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41f41000 41f58000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41f65000 41f67000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41f8d000 41f94000 rw-p [heap]
41f94000 420c6000 rw-p [heap]
4407f000 4487e000 rwxp [stack:16255]
44b17000 44b1c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
44c43000 44c53000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
44d5b000 44d5c000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44de3000 44de4000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44dec000 44df3000 r-xp /usr/lib/libfeedback.so.0.1.4
45015000 45016000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4501e000 45020000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
45028000 45032000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4503a000 45041000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45049000 4505f000 r-xp /usr/lib/libmmfsound.so.0.1.0
45071000 45076000 r-xp /usr/lib/libmmfsession.so.0.0.0
4507e000 45088000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45094000 45098000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
450a1000 450b7000 r-xp /usr/lib/libavsysaudio.so.0.0.1
450c0000 450c5000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
450cd000 450d0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
450d8000 45139000 r-xp /usr/lib/libasound.so.2.0.0
45143000 4517b000 r-xp /usr/lib/libpulse.so.0.16.2
4517c000 4517f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45187000 45194000 r-xp /usr/lib/libail.so.0.1.0
4519d000 451ad000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
451ce000 451d6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
451e5000 451e8000 r-xp /usr/lib/libcompress.so.0.2.0
451f0000 451f5000 r-xp /usr/lib/libjson.so.0.0.1
451fd000 45245000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45246000 45289000 r-xp /usr/lib/libsndfile.so.1.0.25
45296000 452b8000 r-xp /usr/lib/libvorbis.so.0.4.3
452c0000 452c4000 r-xp /usr/lib/libogg.so.0.7.1
be9f5000 bea16000 rwxp [stack]
End of Maps Information

Callstack Information (PID:16001)
Call Stack Count: 1
 0: create_third_page + 0x1b (0x4145fe38) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x2e38
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
m_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:30.098+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-02 14:50:30.098+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-02 14:50:30.098+0900 W/wnotib  (  731): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
04-02 14:50:30.103+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04400008)
04-02 14:50:30.138+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:50:30.138+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:30.138+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:30.138+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:30.138+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:50:30.138+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:50:30.138+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:30.163+0900 I/wnotibp ( 1175): wnotiboard-popup-view.c: wnotiboard_popup_draw_small_view(3659) > ::UI:: window type is changed by unknown causes
04-02 14:50:30.163+0900 I/APP_CORE( 1175): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
04-02 14:50:30.173+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400008)
04-02 14:50:30.183+0900 W/APP_CORE( 1175): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400008
04-02 14:50:30.208+0900 W/AUL_AMD (  473): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-02 14:50:30.208+0900 W/AUL_AMD (  473): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
04-02 14:50:30.218+0900 W/wnotibp ( 1175): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
04-02 14:50:30.218+0900 I/wnotibp ( 1175): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
04-02 14:50:30.218+0900 I/wnotibp ( 1175): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
04-02 14:50:30.223+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
04-02 14:50:30.223+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:30.223+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-02 14:50:30.223+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-02 14:50:30.253+0900 E/EFL     ( 1175): evas_main<1175> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
04-02 14:50:30.253+0900 E/EFL     ( 1175): evas_main<1175> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
04-02 14:50:30.253+0900 E/EFL     ( 1175): evas_main<1175> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
04-02 14:50:30.253+0900 I/wnotibp ( 1175): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
04-02 14:50:30.253+0900 I/wnotibp ( 1175): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
04-02 14:50:30.253+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
04-02 14:50:30.253+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:30.253+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-02 14:50:30.253+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1175): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-02 14:50:30.288+0900 I/wnotibp ( 1175): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x4400008 0x440000a 0x4400008 ]
04-02 14:50:30.288+0900 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: RESUME State: RUNNING
04-02 14:50:30.288+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
04-02 14:50:30.288+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
04-02 14:50:30.293+0900 W/TIZEN_N_RECORDER( 1175): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
04-02 14:50:30.293+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
04-02 14:50:30.293+0900 I/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
04-02 14:50:30.293+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
04-02 14:50:30.293+0900 I/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
04-02 14:50:30.318+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
04-02 14:50:30.318+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
04-02 14:50:30.628+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
04-02 14:50:30.628+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
04-02 14:50:30.628+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
04-02 14:50:30.633+0900 E/wnoti-service(  857): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
04-02 14:50:30.638+0900 E/wnoti-service(  857): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
04-02 14:50:30.638+0900 E/wnoti-service(  857): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
04-02 14:50:30.643+0900 E/wnoti-proxy( 1175): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
04-02 14:50:30.643+0900 E/wnotibp ( 1175): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
04-02 14:50:30.643+0900 W/wnotibp ( 1175): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
04-02 14:50:31.953+0900 E/wnoti-service(  857): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
04-02 14:50:33.103+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
04-02 14:50:33.103+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
04-02 14:50:33.428+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
04-02 14:50:33.428+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
04-02 14:50:33.428+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
04-02 14:50:33.428+0900 W/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
04-02 14:50:33.428+0900 I/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
04-02 14:50:33.433+0900 I/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
04-02 14:50:33.433+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
04-02 14:50:33.433+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
04-02 14:50:33.433+0900 I/wnotibp ( 1175): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 19112
04-02 14:50:33.433+0900 I/wnotibp ( 1175): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
04-02 14:50:33.458+0900 I/efl-extension( 1175): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x48251968, obj: 0x48251968
04-02 14:50:33.458+0900 I/efl-extension( 1175): efl_extension_rotary.c: _object_deleted_cb(601) > done
04-02 14:50:33.513+0900 I/efl-extension( 1175): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:50:33.513+0900 I/efl-extension( 1175): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x48251968, elm_genlist, func : 0x41825dfd
04-02 14:50:33.513+0900 I/efl-extension( 1175): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:50:33.518+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
04-02 14:50:33.518+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
04-02 14:50:33.523+0900 I/efl-extension( 1175): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
04-02 14:50:33.523+0900 I/wnotibp ( 1175): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 1064, 218
04-02 14:50:33.523+0900 I/efl-extension( 1175): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
04-02 14:50:33.523+0900 I/wnotibp ( 1175): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
04-02 14:50:33.538+0900 W/APP_CORE( 1175): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:4400008
04-02 14:50:33.538+0900 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: PAUSE State: RUNNING
04-02 14:50:33.538+0900 I/CAPI_APPFW_APPLICATION( 1175): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:50:33.538+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
04-02 14:50:33.543+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
04-02 14:50:33.543+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:33.543+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:33.543+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:33.543+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
04-02 14:50:33.543+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
04-02 14:50:33.543+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
04-02 14:50:33.548+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
04-02 14:50:33.548+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
04-02 14:50:33.548+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
04-02 14:50:33.548+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:33.548+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:50:33.643+0900 W/wnotibp ( 1175): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
04-02 14:50:33.648+0900 W/wnotibp ( 1175): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
04-02 14:50:33.648+0900 W/wnotibp ( 1175): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 31, 0000]
04-02 14:50:33.648+0900 W/wnotibp ( 1175): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
04-02 14:50:33.648+0900 W/wnotibp ( 1175): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [1, 1, 0, 2, 0]
04-02 14:50:33.953+0900 E/wnoti-service(  857): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
04-02 14:50:36.048+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
04-02 14:50:36.053+0900 E/EFL     (  731): evas_main<731> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8625187 button=1 downs=1
04-02 14:50:36.053+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [193, 187]
04-02 14:50:36.103+0900 E/EFL     (  731): evas_main<731> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8625234 button=1 downs=0
04-02 14:50:36.103+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [193, 187]->[193, 185]
04-02 14:50:36.113+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,18]
04-02 14:50:36.113+0900 E/APPS    (  731): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-02 14:50:36.113+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(410) >  item(ph1) launched, open(0)
04-02 14:50:36.113+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 0
04-02 14:50:36.113+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(1702) > caller pid : 731
04-02 14:50:36.113+0900 I/AUL_AMD (  473): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
04-02 14:50:36.128+0900 E/RESOURCED(  475): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
04-02 14:50:36.128+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
04-02 14:50:36.128+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(2080) > pad pid(-5)
04-02 14:50:36.128+0900 W/AUL_PAD ( 1174): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
04-02 14:50:36.128+0900 W/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(272) > Check app launching
04-02 14:50:36.163+0900 I/efl-extension(16001): efl_extension.c: eext_mod_init(40) > Init
04-02 14:50:36.163+0900 I/UXT     (16001): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
04-02 14:50:36.163+0900 I/CAPI_APPFW_APPLICATION(16001): app_main.c: ui_app_main(704) > app_efl_main
04-02 14:50:36.168+0900 I/CAPI_APPFW_APPLICATION(16001): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-02 14:50:36.203+0900 E/TBM     (16001): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
04-02 14:50:36.233+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:50:36.233+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
04-02 14:50:36.263+0900 E/EFL     (16001): <16001> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
04-02 14:50:36.278+0900 E/EFL     (16001): <16001> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:50:36.278+0900 E/EFL     (16001): <16001> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:50:36.278+0900 E/EFL     (16001): <16001> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:50:36.278+0900 E/EFL     (16001): <16001> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:50:36.338+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05200002)
04-02 14:50:36.383+0900 I/APP_CORE(16001): appcore-efl.c: __do_app(429) > [APP 16001] Event: RESET State: CREATED
04-02 14:50:36.383+0900 I/CAPI_APPFW_APPLICATION(16001): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-02 14:50:36.388+0900 I/MALI    (  731): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1460] swap changed from sync to async
04-02 14:50:36.388+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:50:36.388+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.388+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.393+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.393+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:50:36.403+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:50:36.403+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:36.403+0900 I/APP_CORE(16001): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
04-02 14:50:36.403+0900 I/APP_CORE(16001): appcore-efl.c: __do_app(474) > [APP 16001] Initial Launching, call the resume_cb
04-02 14:50:36.403+0900 I/CAPI_APPFW_APPLICATION(16001): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-02 14:50:36.413+0900 W/APP_CORE(16001): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
04-02 14:50:36.468+0900 I/APP_CORE(16001): appcore-efl.c: __do_app(429) > [APP 16001] Event: RESUME State: RUNNING
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.468+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
04-02 14:50:36.468+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
04-02 14:50:36.468+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:50:36.468+0900 W/W_HOME  (  731): main.c: _appcore_pause_cb(690) > appcore pause
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.468+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:36.468+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47890470
04-02 14:50:36.468+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47890470, elm_layout, func : 0x4004b469
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47890470, activated : 1
04-02 14:50:36.478+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:50:36.478+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:50:36.478+0900 I/wnotib  (  731): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 1066, 218.
04-02 14:50:36.478+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:50:36.488+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:50:36.488+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:50:36.488+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [false][0m
04-02 14:50:36.493+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:36.493+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:36.543+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
04-02 14:50:36.543+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:50:36.558+0900 W/APPS    (  731): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
04-02 14:50:36.863+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:50:36.993+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:50:37.088+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8626225 button=1 downs=1
04-02 14:50:37.158+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8626297 button=1 downs=0
04-02 14:50:37.258+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:50:37.268+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16001
04-02 14:50:37.268+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 12
04-02 14:50:37.598+0900 I/AUL_PAD (16222): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
04-02 14:50:37.888+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:37.893+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:37.903+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:37.903+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:37.903+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:37.903+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:37.953+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:true] pos=0[0m
04-02 14:50:37.983+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:37.983+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:38.038+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:38.043+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
04-02 14:50:38.063+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:38.158+0900 E/AUL_AMD (  473): amd_appinfo.c: appinfo_get_value(999) > appinfo get value: Invalid argument, 9
04-02 14:50:38.493+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:38.493+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:38.653+0900 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: MEM_FLUSH State: PAUSED
04-02 14:50:39.288+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8628422 button=1 downs=1
04-02 14:50:39.368+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8628505 button=1 downs=0
04-02 14:50:41.498+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:50:43.503+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
04-02 14:50:43.518+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
04-02 14:50:43.518+0900 E/WMS     (  469): ==========
04-02 14:50:43.518+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
04-02 14:50:43.518+0900 E/WMS     (  469): ==========
04-02 14:50:43.578+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
04-02 14:50:43.643+0900 W/SCSD    ( 5028): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
04-02 14:50:43.643+0900 W/SCSD    ( 5028): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
04-02 14:50:43.643+0900 W/SCSD    ( 5028): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
04-02 14:50:43.658+0900 W/SCSD    ( 5028): <util_scs_send:975> sent [63 / 63] bytes. 
04-02 14:50:45.838+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8634975 button=1 downs=1
04-02 14:50:45.903+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8635041 button=1 downs=0
04-02 14:50:45.908+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:45.943+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:45.948+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:45.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:45.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:45.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:45.968+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:45.973+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:46.043+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:46.043+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:46.073+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:46.073+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:46.108+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:46.108+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:46.123+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:46.448+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:47.348+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:47.373+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:47.623+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:47.638+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:47.803+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:47.823+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:48.253+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8637385 button=1 downs=1
04-02 14:50:48.348+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8637486 button=1 downs=0
04-02 14:50:48.353+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:48.383+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:48.388+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:48.403+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:48.403+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:48.403+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:48.403+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:48.413+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:48.478+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:48.478+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:48.518+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:48.518+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:48.563+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:48.563+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:48.588+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:48.778+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
04-02 14:50:48.783+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
04-02 14:50:48.783+0900 E/WMS     (  469): ==========
04-02 14:50:48.783+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
04-02 14:50:48.783+0900 E/WMS     (  469): ==========
04-02 14:50:48.788+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
04-02 14:50:48.898+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:48.938+0900 W/SCSD    ( 5028): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
04-02 14:50:48.938+0900 W/SCSD    ( 5028): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
04-02 14:50:48.938+0900 W/SCSD    ( 5028): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
04-02 14:50:48.968+0900 W/SCSD    ( 5028): <util_scs_send:975> sent [63 / 63] bytes. 
04-02 14:50:49.038+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:49.083+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:49.193+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:49.218+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:49.423+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:49.443+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:49.778+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8638916 button=1 downs=1
04-02 14:50:49.858+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8638996 button=1 downs=0
04-02 14:50:49.863+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:49.893+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:49.898+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:49.908+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:49.908+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:49.908+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:49.908+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:49.913+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:49.953+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:49.953+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:49.988+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:49.988+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:50.043+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:50.043+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:50.068+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:50.398+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:50.428+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:50.453+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:50.583+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:50.618+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:50.738+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8639873 button=1 downs=1
04-02 14:50:50.828+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8639966 button=1 downs=0
04-02 14:50:50.833+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:50.863+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:50.868+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:50.883+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:50.883+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:50.883+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:50.883+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:50.883+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:50.928+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:50.928+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:50.963+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:50.963+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:51.023+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:51.028+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:51.063+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:51.373+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:51.468+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:51.518+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:51.653+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:51.673+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:51.878+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:51.898+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:52.633+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:52.663+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x5200002 FAILED!
04-02 14:50:52.758+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_clear(121) > [0;31mrotary_input_clear[0m
04-02 14:50:52.763+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
04-02 14:50:52.768+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
04-02 14:50:52.768+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
04-02 14:50:52.768+0900 E/ISE_MULTI(  995): rotary_input.cpp: destroy_rotary_input_layout(622) > [0;31mdestroy_rotary_input_layout[0m
04-02 14:50:52.768+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:53.423+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:53.723+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8642858 button=1 downs=1
04-02 14:50:53.783+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8642923 button=1 downs=0
04-02 14:50:53.798+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:true][0m
04-02 14:50:53.818+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:53.823+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:54.068+0900 D/IP      (16001): 192.168.43.165
04-02 14:50:54.068+0900 D/PORT    (16001): 7777
04-02 14:50:54.073+0900 I/IP      (16001): 192.168.43.165
04-02 14:50:54.323+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:58.263+0900 E/EFL     (16001): evas_main<16001> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8647400 button=1 downs=1
04-02 14:50:58.343+0900 E/EFL     (16001): evas_main<16001> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8647468 button=1 downs=0
04-02 14:50:58.843+0900 W/CRASH_MANAGER(16141): worker.c: worker_job(1199) > 1116001706831145957625
