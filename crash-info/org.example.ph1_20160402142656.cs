S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 10685
Date: 2016-04-02 14:26:56+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10685, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x457aa1b0, r5   = 0x4430a5c0
r6   = 0x442ec950, r7   = 0xbe99b2a8
r8   = 0x00000000, r9   = 0x45796550
r10  = 0x457babb0, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbe99b250
lr   = 0x00000000, pc   = 0x40002df0
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     22956 KB
Buffers:     42428 KB
Cached:     148800 KB
VmPeak:      98420 KB
VmSize:      96048 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21288 KB
VmRSS:       21284 KB
VmData:      34236 KB
VmStk:         136 KB
VmExe:          16 KB
VmLib:       56152 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10685 TID = 10685
10685 10690 10691 10740 

Maps Information
40000000 40004000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000b000 4000c000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
4000c000 40029000 r-xp /lib/ld-2.13.so
40030000 40031000 r-xp /lib/ld-2.13.so
40031000 40032000 rwxp /lib/ld-2.13.so
40032000 40036000 r-xp /usr/lib/libsys-assert.so
4003e000 4003f000 rwxp /usr/lib/libsys-assert.so
4003f000 4004a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40052000 40053000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40053000 40054000 r-xp /usr/share/locale/locale-archive
40054000 40068000 r-xp /lib/libpthread-2.13.so
4006f000 40070000 r-xp /lib/libpthread-2.13.so
40070000 40071000 rwxp /lib/libpthread-2.13.so
40073000 40077000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4007e000 4007f000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4007f000 4008c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
40093000 40094000 rwxp /usr/lib/libcapi-network-connection.so.1.0.51
40094000 4009c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4009c000 4009d000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
4009d000 4009f000 r-xp /usr/lib/libdlog.so.0.0.0
400a6000 400a7000 rwxp /usr/lib/libdlog.so.0.0.0
400a7000 400c8000 r-xp /usr/lib/libefl-extension.so.0.1.0
400cf000 400d0000 rwxp /usr/lib/libefl-extension.so.0.1.0
400d0000 4020a000 r-xp /usr/lib/libelementary.so.1.7.99
40211000 40219000 rwxp /usr/lib/libelementary.so.1.7.99
40220000 402ee000 r-xp /usr/lib/libevas.so.1.7.99
402f6000 40300000 rwxp /usr/lib/libevas.so.1.7.99
40313000 4042e000 r-xp /lib/libc-2.13.so
40436000 40438000 r-xp /lib/libc-2.13.so
40438000 40439000 rwxp /lib/libc-2.13.so
4043c000 40447000 r-xp /lib/libunwind.so.8.0.1
4044e000 4044f000 rwxp /lib/libunwind.so.8.0.1
40474000 40476000 r-xp /lib/libdl-2.13.so
4047d000 4047e000 r-xp /lib/libdl-2.13.so
4047e000 4047f000 rwxp /lib/libdl-2.13.so
4047f000 40487000 r-xp /lib/libgcc_s-4.6.so.1
40487000 40488000 rwxp /lib/libgcc_s-4.6.so.1
40488000 4048c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40494000 40495000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40495000 40497000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4049f000 404a0000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404a0000 404a5000 r-xp /usr/lib/libappcore-efl.so.1.1
404ac000 404ad000 rwxp /usr/lib/libappcore-efl.so.1.1
404ad000 404b2000 r-xp /usr/lib/libappcore-common.so.1.1
404b9000 404ba000 rwxp /usr/lib/libappcore-common.so.1.1
404ba000 404c6000 r-xp /usr/lib/libaul.so.0.1.0
404ce000 404cf000 rwxp /usr/lib/libaul.so.0.1.0
404d0000 404f2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404f9000 404fa000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
404fa000 4053b000 r-xp /usr/lib/libeina.so.1.7.99
40542000 40544000 rwxp /usr/lib/libeina.so.1.7.99
40544000 40548000 r-xp /usr/lib/libvconf.so.0.2.45
4054f000 40550000 rwxp /usr/lib/libvconf.so.0.2.45
40550000 40567000 r-xp /usr/lib/libnetwork.so.0.0.0
4056e000 4056f000 rwxp /usr/lib/libnetwork.so.0.0.0
4056f000 4063f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4063f000 40640000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40640000 40645000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4064c000 4064d000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
4064d000 4069d000 r-xp /usr/lib/libecore_x.so.1.7.99
4069d000 4069f000 rwxp /usr/lib/libecore_x.so.1.7.99
4069f000 406c1000 r-xp /usr/lib/libecore_evas.so.1.7.99
406c8000 406ca000 rwxp /usr/lib/libecore_evas.so.1.7.99
406ca000 406f2000 r-xp /usr/lib/libfontconfig.so.1.8.0
406f2000 406f3000 rwxp /usr/lib/libfontconfig.so.1.8.0
406f3000 407bf000 r-xp /usr/lib/libxml2.so.2.7.8
407c6000 407cb000 rwxp /usr/lib/libxml2.so.2.7.8
407cc000 407de000 r-xp /usr/lib/libefl-assist.so.0.1.0
407e5000 407e6000 rwxp /usr/lib/libefl-assist.so.0.1.0
407e6000 4084f000 r-xp /lib/libm-2.13.so
40856000 40857000 r-xp /lib/libm-2.13.so
40857000 40858000 rwxp /lib/libm-2.13.so
40858000 4086f000 r-xp /usr/lib/libecore.so.1.7.99
40877000 40878000 rwxp /usr/lib/libecore.so.1.7.99
40886000 408e3000 r-xp /usr/lib/libedje.so.1.7.99
408eb000 408ed000 rwxp /usr/lib/libedje.so.1.7.99
408ed000 409a5000 r-xp /usr/lib/libcairo.so.2.11200.14
409ac000 409af000 rwxp /usr/lib/libcairo.so.2.11200.14
409b0000 40a91000 r-xp /usr/lib/libX11.so.6.3.0
40a98000 40a9c000 rwxp /usr/lib/libX11.so.6.3.0
40a9c000 40aa5000 r-xp /usr/lib/libXi.so.6.1.0
40aac000 40aad000 rwxp /usr/lib/libXi.so.6.1.0
40aad000 40ac6000 r-xp /usr/lib/libeet.so.1.7.99
40ace000 40acf000 rwxp /usr/lib/libeet.so.1.7.99
40ad7000 40adc000 r-xp /usr/lib/libecore_file.so.1.7.99
40ae3000 40ae4000 rwxp /usr/lib/libecore_file.so.1.7.99
40ae4000 40af5000 r-xp /usr/lib/libecore_input.so.1.7.99
40afc000 40afd000 rwxp /usr/lib/libecore_input.so.1.7.99
40afd000 40b06000 r-xp /usr/lib/libedbus.so.1.7.99
40b0d000 40b0e000 rwxp /usr/lib/libedbus.so.1.7.99
40b0e000 40b38000 r-xp /usr/lib/libdbus-1.so.3.8.12
40b40000 40b41000 rwxp /usr/lib/libdbus-1.so.3.8.12
40b41000 40b5b000 r-xp /usr/lib/libecore_con.so.1.7.99
40b62000 40b63000 rwxp /usr/lib/libecore_con.so.1.7.99
40b64000 40b77000 r-xp /usr/lib/libfribidi.so.0.3.1
40b7e000 40b7f000 rwxp /usr/lib/libfribidi.so.0.3.1
40b7f000 40bbc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40bc3000 40bc4000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40bc5000 40c1b000 r-xp /usr/lib/libfreetype.so.6.11.3
40c23000 40c27000 rwxp /usr/lib/libfreetype.so.6.11.3
40c27000 40c7d000 r-xp /usr/lib/libpixman-1.so.0.28.2
40c85000 40c8a000 rwxp /usr/lib/libpixman-1.so.0.28.2
40c8a000 40c90000 r-xp /usr/lib/libappsvc.so.0.1.0
40c97000 40c98000 rwxp /usr/lib/libappsvc.so.0.1.0
40c98000 40c9b000 r-xp /usr/lib/libbundle.so.0.1.22
40ca2000 40ca3000 rwxp /usr/lib/libbundle.so.0.1.22
40ca3000 40ca9000 r-xp /usr/lib/libecore_imf.so.1.7.99
40cb0000 40cb1000 rwxp /usr/lib/libecore_imf.so.1.7.99
40cb1000 40ce5000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40cec000 40cee000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40cee000 40cf0000 r-xp /usr/lib/libiniparser.so.0
40cf8000 40cf9000 rwxp /usr/lib/libiniparser.so.0
40cf9000 40d10000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40d17000 40d18000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40d18000 40d1d000 r-xp /usr/lib/libxdgmime.so.1.1.0
40d24000 40d25000 rwxp /usr/lib/libxdgmime.so.1.1.0
40d25000 40d61000 r-xp /usr/lib/libsystemd.so.0.4.0
40d68000 40d69000 r-xp /usr/lib/libsystemd.so.0.4.0
40d69000 40d6a000 rwxp /usr/lib/libsystemd.so.0.4.0
40d6a000 40d6d000 r-xp /usr/lib/libproc-stat.so.0.2.86
40d74000 40d75000 rwxp /usr/lib/libproc-stat.so.0.2.86
40d75000 40d8b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40d92000 40d93000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40d93000 40e08000 r-xp /usr/lib/libsqlite3.so.0.8.6
40e0f000 40e12000 rwxp /usr/lib/libsqlite3.so.0.8.6
40e12000 40e18000 r-xp /lib/librt-2.13.so
40e1f000 40e20000 r-xp /lib/librt-2.13.so
40e20000 40e21000 rwxp /lib/librt-2.13.so
40e21000 40ef4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40efb000 40eff000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40eff000 40f30000 r-xp /usr/lib/libmdm.so.1.1.85
40f37000 40f38000 rwxp /usr/lib/libmdm.so.1.1.85
40f38000 40f3f000 r-xp /usr/lib/libXcursor.so.1.0.2
40f46000 40f47000 rwxp /usr/lib/libXcursor.so.1.0.2
40f47000 40f49000 r-xp /usr/lib/libXdamage.so.1.1.0
40f50000 40f51000 rwxp /usr/lib/libXdamage.so.1.1.0
40f51000 40f53000 r-xp /usr/lib/libXcomposite.so.1.0.0
40f5a000 40f5b000 rwxp /usr/lib/libXcomposite.so.1.0.0
40f5b000 40f5d000 r-xp /usr/lib/libXgesture.so.7.0.0
40f64000 40f65000 rwxp /usr/lib/libXgesture.so.7.0.0
40f65000 40f68000 r-xp /usr/lib/libXfixes.so.3.1.0
40f6f000 40f70000 rwxp /usr/lib/libXfixes.so.3.1.0
40f70000 40f71000 r-xp /usr/lib/libXinerama.so.1.0.0
40f79000 40f7a000 rwxp /usr/lib/libXinerama.so.1.0.0
40f7a000 40f80000 r-xp /usr/lib/libXrandr.so.2.2.0
40f87000 40f88000 rwxp /usr/lib/libXrandr.so.2.2.0
40f88000 40f8e000 r-xp /usr/lib/libXrender.so.1.3.0
40f95000 40f96000 rwxp /usr/lib/libXrender.so.1.3.0
40f96000 40f9a000 r-xp /usr/lib/libXtst.so.6.1.0
40fa1000 40fa2000 rwxp /usr/lib/libXtst.so.6.1.0
40fa2000 40fac000 r-xp /usr/lib/libXext.so.6.4.0
40fb4000 40fb5000 rwxp /usr/lib/libXext.so.6.4.0
40fb5000 40fba000 r-xp /usr/lib/libecore_fb.so.1.7.99
40fc1000 40fc3000 rwxp /usr/lib/libecore_fb.so.1.7.99
40fc3000 40fc7000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40fcf000 40fd0000 rwxp /usr/lib/libecore_ipc.so.1.7.99
40fd0000 40fd3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40fda000 40fdb000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
40fdb000 40ff1000 r-xp /lib/libexpat.so.1.5.2
40ff9000 40ffb000 rwxp /lib/libexpat.so.1.5.2
40ffb000 41011000 r-xp /lib/libz.so.1.2.5
41018000 41019000 rwxp /lib/libz.so.1.2.5
4101a000 4102c000 r-xp /usr/lib/libtts.so
41033000 41034000 rwxp /usr/lib/libtts.so
41034000 41055000 r-xp /usr/lib/libui-extension.so.0.1.0
4105d000 4105e000 rwxp /usr/lib/libui-extension.so.0.1.0
4105e000 41065000 r-xp /usr/lib/libtbm.so.1.0.0
4106c000 4106d000 rwxp /usr/lib/libtbm.so.1.0.0
4106d000 41074000 r-xp /usr/lib/libembryo.so.1.7.99
4107b000 4107c000 rwxp /usr/lib/libembryo.so.1.7.99
4107c000 41093000 r-xp /usr/lib/liblua-5.1.so
4109b000 4109c000 rwxp /usr/lib/liblua-5.1.so
4109c000 4109d000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
410a4000 410a5000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
410a6000 410b4000 r-xp /usr/lib/libGLESv2.so.2.0
410bc000 410bd000 rwxp /usr/lib/libGLESv2.so.2.0
410bd000 410d5000 r-xp /usr/lib/libpng12.so.0.50.0
410dc000 410dd000 rwxp /usr/lib/libpng12.so.0.50.0
410dd000 410de000 r-xp /usr/lib/libxcb-shm.so.0.0.0
410e6000 410e7000 rwxp /usr/lib/libxcb-shm.so.0.0.0
410e7000 410ed000 r-xp /usr/lib/libxcb-render.so.0.0.0
410f4000 410f5000 rwxp /usr/lib/libxcb-render.so.0.0.0
410f5000 41108000 r-xp /usr/lib/libxcb.so.1.1.0
41110000 41111000 rwxp /usr/lib/libxcb.so.1.1.0
41111000 41114000 r-xp /usr/lib/libEGL.so.1.4
4111b000 4111c000 rwxp /usr/lib/libEGL.so.1.4
4111d000 41140000 r-xp /usr/lib/libjpeg.so.8.0.2
41147000 41148000 rwxp /usr/lib/libjpeg.so.8.0.2
41158000 4119c000 r-xp /usr/lib/libcurl.so.4.3.0
411a3000 411a5000 rwxp /usr/lib/libcurl.so.4.3.0
411a5000 411ab000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
411b3000 411b4000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
411b4000 411b5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
411bc000 411bd000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
411be000 411c3000 r-xp /usr/lib/libffi.so.5.0.10
411ca000 411cb000 rwxp /usr/lib/libffi.so.5.0.10
411cb000 411e3000 r-xp /usr/lib/liblzma.so.5.0.3
411ea000 411eb000 rwxp /usr/lib/liblzma.so.5.0.3
411eb000 41267000 r-xp /usr/lib/libgcrypt.so.20.0.3
4126e000 41273000 rwxp /usr/lib/libgcrypt.so.20.0.3
41273000 41283000 r-xp /lib/libresolv-2.13.so
41283000 41284000 r-xp /lib/libresolv-2.13.so
41284000 41285000 rwxp /lib/libresolv-2.13.so
41287000 41289000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41291000 41292000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
41293000 41295000 r-xp /usr/lib/journal/libjournal.so.0.1.0
4129c000 4129d000 rwxp /usr/lib/journal/libjournal.so.0.1.0
4129d000 4129f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
412a6000 412a7000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
412a7000 412af000 r-xp /usr/lib/libmdm-common.so.1.0.89
412af000 412b0000 rwxp /usr/lib/libmdm-common.so.1.0.89
412b0000 413ed000 r-xp /usr/lib/libicui18n.so.51.1
413f5000 413fd000 rwxp /usr/lib/libicui18n.so.51.1
413fe000 414e2000 r-xp /usr/lib/libicuuc.so.51.1
414e9000 414f3000 rwxp /usr/lib/libicuuc.so.51.1
414f7000 414fa000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41501000 41502000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
41502000 41505000 r-xp /usr/lib/libsmack.so.1.0.0
4150c000 4150d000 rwxp /usr/lib/libsmack.so.1.0.0
4150d000 415a1000 r-xp /usr/lib/libstdc++.so.6.0.16
415a9000 415ac000 r-xp /usr/lib/libstdc++.so.6.0.16
415ac000 415ae000 rwxp /usr/lib/libstdc++.so.6.0.16
415b4000 415bc000 r-xp /usr/lib/libdrm.so.2.4.0
415c3000 415c4000 rwxp /usr/lib/libdrm.so.2.4.0
415c5000 415c7000 r-xp /usr/lib/libXau.so.6.0.0
415ce000 415cf000 rwxp /usr/lib/libXau.so.6.0.0
415cf000 415d8000 r-xp /usr/lib/libcares.so.2.1.0
415e0000 415e1000 rwxp /usr/lib/libcares.so.2.1.0
415e1000 4160f000 r-xp /usr/lib/libidn.so.11.5.44
41616000 41617000 rwxp /usr/lib/libidn.so.11.5.44
41617000 41664000 r-xp /usr/lib/libssl.so.1.0.0
4166b000 41670000 rwxp /usr/lib/libssl.so.1.0.0
41670000 41818000 r-xp /usr/lib/libcrypto.so.1.0.0
41818000 4182d000 rwxp /usr/lib/libcrypto.so.1.0.0
41832000 4183d000 r-xp /usr/lib/libgpg-error.so.0.15.0
41844000 41845000 rwxp /usr/lib/libgpg-error.so.0.15.0
41845000 42dc4000 r-xp /usr/lib/libicudata.so.51.1
42dcb000 42dcc000 rwxp /usr/lib/libicudata.so.51.1
42dcc000 42dd1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42dd9000 42dda000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42dda000 42ddf000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42de6000 42de7000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42de8000 42dea000 r-xp /usr/lib/libdri2.so.0.0.0
42df1000 42df2000 rwxp /usr/lib/libdri2.so.0.0.0
42df2000 42e13000 r-xp /usr/lib/libexif.so.12.3.3
42e1a000 42e26000 rwxp /usr/lib/libexif.so.12.3.3
42e26000 42e2b000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e32000 42e33000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42f3a000 43004000 r-xp /usr/lib/libCOREGL.so.4.0
4300c000 4300e000 rwxp /usr/lib/libCOREGL.so.4.0
43016000 4303a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
43041000 43043000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
43043000 43112000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43119000 43128000 rwxp /usr/lib/libscim-1.0.so.8.2.3
43128000 43155000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
4315c000 4315d000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
4315d000 4317a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
43182000 43183000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
43183000 43185000 r-xp /usr/lib/libiri.so
4318c000 4318d000 rwxp /usr/lib/libiri.so
4318d000 43190000 r-xp /lib/libcap.so.2.21
43197000 43198000 rwxp /lib/libcap.so.2.21
43198000 4319f000 r-xp /lib/libcrypt-2.13.so
431a6000 431a7000 r-xp /lib/libcrypt-2.13.so
431a7000 431a8000 rwxp /lib/libcrypt-2.13.so
431cf000 431d2000 r-xp /lib/libattr.so.1.1.0
431d9000 431da000 rwxp /lib/libattr.so.1.1.0
431da000 431e4000 r-xp /lib/libnss_files-2.13.so
431eb000 431ec000 r-xp /lib/libnss_files-2.13.so
431ec000 431ed000 rwxp /lib/libnss_files-2.13.so
431ed000 433ed000 r-xp /usr/share/locale/locale-archive
433ed000 4351e000 r-xp /usr/share/locale/locale-archive
4351e000 43595000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4359d000 4359f000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
435a5000 436ed000 r-xp /usr/lib/egl/libMali.so
436ed000 436f2000 rwxp /usr/lib/egl/libMali.so
436f3000 436f6000 rwxp [stack:10691]
436f6000 436fa000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43701000 43702000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43702000 43706000 rwxs /dev/mali
43707000 4370a000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43711000 43712000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43713000 43f12000 rwxp [stack:10690]
43f12000 43f1a000 rwxs /dev/mali
43f1a000 43f22000 rwxs /dev/mali
43f22000 43f36000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
44036000 4403a000 rwxs /dev/mali
4403a000 4403e000 rwxs /dev/mali
4403e000 44046000 rwxs /dev/mali
44046000 4404e000 rwxs /dev/mali
4404e000 44050000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44050000 441ef000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
441ef000 44206000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4420e000 44213000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44313000 44315000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4431c000 4431d000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4431e000 44b1d000 rwxp [stack:10740]
44b1d000 44b20000 r-xs /opt/home/app/.cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b20000 44b24000 r-xs /opt/home/app/.cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b24000 44b33000 r-xs /opt/home/app/.cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44b33000 44bbe000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
44bbe000 44bfe000 rwxs /dev/mali
45500000 45540000 rwxs /dev/mali
45540000 45547000 r-xs /usr/lib/gconv/gconv-modules.cache
45547000 4554c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
45553000 45554000 rwxp /usr/lib/scim-1.0/1.4.0/Config/socket.so
45554000 45578000 rwxs /dev/mali
45578000 4557c000 rwxs /dev/mali
4557c000 455a0000 rwxs /dev/mali
455a0000 455a4000 rwxs /dev/mali
455a4000 455c8000 rwxs /dev/mali
455c8000 455cc000 rwxs /dev/mali
455cc000 45658000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
45658000 45777000 r-xp /usr/share/locale/locale-archive
45777000 45787000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
4578e000 4578f000 rwxp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
4578f000 45793000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/scim.mo
45893000 45894000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4589b000 4589c000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4589c000 45924000 rwxs /dev/mali
45924000 45925000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4592c000 4592d000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45942000 45949000 r-xp /usr/lib/libfeedback.so.0.1.4
45951000 45952000 rwxp /usr/lib/libfeedback.so.0.1.4
45952000 45953000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4595a000 4595b000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
4595b000 4595d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
45964000 45965000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
45965000 4596f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45976000 45977000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45977000 4597e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45985000 45986000 rwxp /usr/lib/libmmfcommon.so.0.0.0
45986000 4599c000 r-xp /usr/lib/libmmfsound.so.0.1.0
459a4000 459a5000 rwxp /usr/lib/libmmfsound.so.0.1.0
459ae000 459b3000 r-xp /usr/lib/libmmfsession.so.0.0.0
459ba000 459bb000 rwxp /usr/lib/libmmfsession.so.0.0.0
459bc000 459c0000 rwxs /dev/mali
459c0000 459d0000 rwxs /dev/mali
459d4000 459e4000 rwxs /dev/mali
459e4000 459ee000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
459f6000 459f7000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
459fa000 459fe000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45a06000 45a07000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
45a08000 45a0c000 rwxs /dev/mali
45a0c000 45a22000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a2a000 45a2b000 rwxp /usr/lib/libavsysaudio.so.0.0.1
45a2b000 45a30000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45a37000 45a38000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
45a38000 45a3b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a42000 45a43000 rwxp /usr/lib/libpulse-simple.so.0.0.4
45a43000 45a7b000 r-xp /usr/lib/libpulse.so.0.16.2
45a7b000 45a7c000 rwxp /usr/lib/libpulse.so.0.16.2
45a7c000 45a7f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a86000 45a87000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
45a87000 45a94000 r-xp /usr/lib/libail.so.0.1.0
45a9c000 45a9d000 rwxp /usr/lib/libail.so.0.1.0
45aa4000 45ae4000 rwxs /dev/mali
45ae4000 45b10000 rwxs /dev/mali
45b10000 45b18000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45b1f000 45b20000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
45b27000 45b2a000 r-xp /usr/lib/libcompress.so.0.2.0
45b31000 45b32000 rwxp /usr/lib/libcompress.so.0.2.0
45b48000 45b4d000 r-xp /usr/lib/libjson.so.0.0.1
45b54000 45b55000 rwxp /usr/lib/libjson.so.0.0.1
45b55000 45b59000 r-xp /usr/lib/libogg.so.0.7.1
45b60000 45b61000 rwxp /usr/lib/libogg.so.0.7.1
45b6c000 45b7c000 rwxs /dev/mali
45b7c000 45bdd000 r-xp /usr/lib/libasound.so.2.0.0
45be4000 45be7000 rwxp /usr/lib/libasound.so.2.0.0
45be7000 45bf7000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45bf7000 45bfb000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
45c18000 45c60000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c60000 45c61000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c61000 45ca4000 r-xp /usr/lib/libsndfile.so.1.0.25
45cab000 45cad000 rwxp /usr/lib/libsndfile.so.1.0.25
45cb1000 45cd3000 r-xp /usr/lib/libvorbis.so.0.4.3
45cda000 45cdb000 rwxp /usr/lib/libvorbis.so.0.4.3
be97b000 be99c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10685)
Call Stack Count: 1
 0: create_third_page + 0x1b (0x40002df0) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x2df0
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
eart_memory_get_data,601] hashtable heart_memory_app_list is NULL
04-02 14:26:20.718+0900 E/AUL_PAD (10582): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
04-02 14:26:20.718+0900 E/AUL_PAD (10582): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
04-02 14:26:20.833+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:20.833+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:20.933+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:20.933+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.038+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.038+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.143+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.143+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.263+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.263+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.368+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.368+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.478+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.478+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.583+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.583+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.688+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.688+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.793+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.793+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:21.903+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:21.903+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.008+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.008+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.113+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.113+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.218+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.218+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.323+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.323+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.428+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.428+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.533+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.533+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.638+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.638+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.748+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.748+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.853+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.853+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:22.958+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:22.958+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.063+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.063+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.168+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.168+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.278+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.278+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.383+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.383+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.493+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.493+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.598+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.598+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.703+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.703+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.808+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.808+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:23.913+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:23.913+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.018+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.018+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.123+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.123+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.228+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.233+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.338+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.338+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.443+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.443+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.548+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.553+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.653+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.653+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.758+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.763+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.868+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.868+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:24.973+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:24.973+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.083+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.083+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.188+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.188+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.298+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.298+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.408+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.408+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.513+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.518+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.618+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.618+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.723+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.723+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.828+0900 E/RESOURCED( 1174): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:25.828+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
04-02 14:26:25.843+0900 E/AUL     (10677): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
04-02 14:26:25.913+0900 E/AUL     (  473): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
04-02 14:26:25.913+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
04-02 14:26:25.923+0900 W/AUL_AMD (  473): amd_launch.c: start_process(580) > child process: 10685
04-02 14:26:25.928+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
04-02 14:26:25.928+0900 E/AUL_PAD ( 1174): launchpad.c: __real_send(253) > send failed due to EPIPE.
04-02 14:26:25.928+0900 E/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
04-02 14:26:25.978+0900 E/AUL_AMD (  473): amd_launch.c: __check_cmdline(520) > error founded when being launched with 10685
04-02 14:26:26.028+0900 W/AUL_AMD (  473): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 10685
04-02 14:26:26.028+0900 E/AUL_AMD (  473): amd_launch.c: __real_send(824) > send failed due to EPIPE.
04-02 14:26:26.028+0900 E/AUL_AMD (  473): amd_launch.c: __real_send(826) > send fail to client
04-02 14:26:26.063+0900 I/AUL_AMD (  473): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 10582
04-02 14:26:26.068+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
04-02 14:26:26.193+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:26:26.203+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10685
04-02 14:26:26.208+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 12
04-02 14:26:26.248+0900 I/efl-extension(10685): efl_extension.c: eext_mod_init(40) > Init
04-02 14:26:26.268+0900 I/CAPI_APPFW_APPLICATION(10685): app_main.c: ui_app_main(704) > app_efl_main
04-02 14:26:26.313+0900 I/UXT     (10685): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
04-02 14:26:26.478+0900 I/CAPI_APPFW_APPLICATION(10685): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-02 14:26:26.538+0900 E/TBM     (10685): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
04-02 14:26:26.698+0900 E/EFL     (10685): <10685> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
04-02 14:26:26.708+0900 E/EFL     (10685): <10685> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:26:26.708+0900 E/EFL     (10685): <10685> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:26:26.708+0900 E/EFL     (10685): <10685> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:26:26.713+0900 E/EFL     (10685): <10685> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:26:26.758+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03400003)
04-02 14:26:26.758+0900 I/APP_CORE(10685): appcore-efl.c: __do_app(429) > [APP 10685] Event: RESET State: CREATED
04-02 14:26:26.758+0900 I/CAPI_APPFW_APPLICATION(10685): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-02 14:26:26.783+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:26:26.783+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.783+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.788+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.788+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:26:26.788+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:26:26.788+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:26:26.793+0900 I/APP_CORE(10685): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
04-02 14:26:26.793+0900 I/APP_CORE(10685): appcore-efl.c: __do_app(474) > [APP 10685] Initial Launching, call the resume_cb
04-02 14:26:26.793+0900 I/CAPI_APPFW_APPLICATION(10685): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-02 14:26:26.813+0900 W/APP_CORE(10685): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400003
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.868+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
04-02 14:26:26.868+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
04-02 14:26:26.868+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:26:26.868+0900 W/W_HOME  (  731): main.c: _appcore_pause_cb(690) > appcore pause
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.868+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:26:26.868+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47890470
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47890470, elm_layout, func : 0x4004b469
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47890470, activated : 1
04-02 14:26:26.868+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:26:26.868+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:26:26.868+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:26:26.883+0900 W/AUL_AMD (  473): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-02 14:26:26.883+0900 W/AUL_AMD (  473): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:26:26.893+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:26:26.898+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:26:26.898+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:26:26.898+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:26:26.898+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:26:26.898+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [false][0m
04-02 14:26:26.943+0900 I/APP_CORE(10685): appcore-efl.c: __do_app(429) > [APP 10685] Event: RESUME State: RUNNING
04-02 14:26:26.978+0900 E/RESOURCED( 1027): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
04-02 14:26:26.978+0900 E/AUL     ( 1027): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
04-02 14:26:26.978+0900 E/CAPI_APPFW_APP_MANAGER( 1027): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-02 14:26:26.983+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
04-02 14:26:26.983+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:26:27.008+0900 W/APPS    (  731): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
04-02 14:26:27.263+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:26:27.283+0900 I/AUL_PAD (10695): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
04-02 14:26:27.298+0900 I/MALI    (10685): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42ef9588] swap changed from async to sync
04-02 14:26:27.398+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:26:31.918+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:26:33.713+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7182851 button=1 downs=1
04-02 14:26:33.738+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7182876 button=1 downs=0
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 81 -> 80 1459574794 443
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 80 1144 194 1525
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 80 0 0 998
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 80 1251 733 1668
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 80 571 5 761
04-02 14:26:34.248+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 80 764 14 1019
04-02 14:26:34.468+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:34.473+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:26:34.473+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:26:34.473+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:26:34.473+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:26:34.478+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:34.573+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:true] pos=0[0m
04-02 14:26:34.663+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:26:34.663+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:26:34.723+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:26:34.733+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
04-02 14:26:34.753+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:26:34.898+0900 E/AUL_AMD (  473): amd_appinfo.c: appinfo_get_value(999) > appinfo get value: Invalid argument, 9
04-02 14:26:35.093+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:35.113+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:26:35.123+0900 I/MALI    (10685): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42ef9588] swap changed from sync to async
04-02 14:26:35.233+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:35.233+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:36.773+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [65288][0m
04-02 14:26:36.788+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:26:37.368+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7186501 button=1 downs=1
04-02 14:26:37.483+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7186620 button=1 downs=0
04-02 14:26:38.208+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7187343 button=1 downs=1
04-02 14:26:38.288+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7187427 button=1 downs=0
04-02 14:26:38.448+0900 I/SWIFTKEY(  874): isf_swiftkey_imengine.cpp: focus_in_timer(372) > [0;36mfocus_in_timer[0m
04-02 14:26:38.473+0900 I/SWIFTKEY(  874): isf_swiftkey_imengine.cpp: reload_config_thread(247) > [0;36mg_prediction_setting_value = [1], arg = [1], try--1[0m
04-02 14:26:39.378+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7188515 button=1 downs=1
04-02 14:26:39.488+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7188624 button=1 downs=0
04-02 14:26:39.488+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:40.508+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Load_lang(1040) > [0;36mSuccessfully loaded DB : en_US[0m
04-02 14:26:40.523+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:26:40.523+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:40.533+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:26:40.533+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:26:40.533+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:26:40.533+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:26:40.533+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:40.563+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:26:40.563+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:40.583+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:26:40.583+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:26:40.608+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:26:40.608+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:40.628+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:26:40.753+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7189157 button=1 downs=1
04-02 14:26:40.753+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7189256 button=1 downs=0
04-02 14:26:40.758+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:40.758+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7189666 button=1 downs=1
04-02 14:26:40.763+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7189764 button=1 downs=0
04-02 14:26:40.763+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:41.013+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:42.668+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:42.698+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:26:42.793+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:42.808+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:26:43.018+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:43.028+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:26:43.553+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7192690 button=1 downs=1
04-02 14:26:43.638+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7192771 button=1 downs=0
04-02 14:26:43.638+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:43.668+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:26:43.673+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:43.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:26:43.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:26:43.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:26:43.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:26:43.688+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:43.723+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:26:43.723+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:43.758+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:26:43.758+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:26:43.803+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:26:43.808+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:43.823+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:26:44.178+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:45.468+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:45.488+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:26:45.668+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:45.688+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:26:45.963+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:45.973+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:26:46.343+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7195477 button=1 downs=1
04-02 14:26:46.408+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7195547 button=1 downs=0
04-02 14:26:46.413+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:46.438+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:26:46.443+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:46.453+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:26:46.453+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:26:46.453+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:26:46.453+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:26:46.463+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:46.528+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:26:46.528+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:46.558+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:26:46.558+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:26:46.593+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:26:46.598+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:46.623+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:26:46.943+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:48.193+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:48.228+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:26:48.308+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:48.328+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:26:48.713+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7197850 button=1 downs=1
04-02 14:26:48.758+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7197898 button=1 downs=0
04-02 14:26:49.313+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7198447 button=1 downs=1
04-02 14:26:49.393+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7198532 button=1 downs=0
04-02 14:26:50.153+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7199271 button=1 downs=1
04-02 14:26:50.213+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7199352 button=1 downs=0
04-02 14:26:50.218+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:50.248+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:26:50.253+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:50.263+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:26:50.268+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:26:50.268+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:26:50.268+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:26:50.273+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:50.338+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:26:50.338+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:50.373+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:26:50.373+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:26:50.418+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:26:50.418+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:26:50.453+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:26:50.758+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:52.428+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:52.448+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:26:52.578+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:52.598+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:26:52.868+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:26:52.888+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:26:53.623+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [65293][0m
04-02 14:26:54.828+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:26:54.868+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400003 FAILED!
04-02 14:26:54.963+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_clear(121) > [0;31mrotary_input_clear[0m
04-02 14:26:54.968+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
04-02 14:26:54.968+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
04-02 14:26:54.968+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
04-02 14:26:54.968+0900 E/ISE_MULTI(  995): rotary_input.cpp: destroy_rotary_input_layout(622) > [0;31mdestroy_rotary_input_layout[0m
04-02 14:26:54.968+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:55.488+0900 I/MALI    (10685): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42ef9588] swap changed from async to sync
04-02 14:26:55.623+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:55.908+0900 E/EFL     (10685): evas_main<10685> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7205043 button=1 downs=1
04-02 14:26:55.983+0900 E/EFL     (10685): evas_main<10685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7205118 button=1 downs=0
04-02 14:26:55.993+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:true][0m
04-02 14:26:56.023+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:26:56.033+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:26:56.258+0900 D/IP      (10685): 192.168.43.165
04-02 14:26:56.258+0900 D/PORT    (10685): 7777
04-02 14:26:56.528+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:26:56.673+0900 W/CRASH_MANAGER(10863): worker.c: worker_job(1199) > 1110685706831145957481
