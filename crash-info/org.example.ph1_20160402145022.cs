S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 16003
Date: 2016-04-02 14:50:22+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16003, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x44215358, r5   = 0x44227870
r6   = 0x442daff8, r7   = 0xbe932328
r8   = 0x00000000, r9   = 0x44239a48
r10  = 0x44256458, fp   = 0x00000001
ip   = 0x44227870, sp   = 0xbe9322d0
lr   = 0x00000000, pc   = 0x40002e38
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     25616 KB
Buffers:     43656 KB
Cached:     140016 KB
VmPeak:     100524 KB
VmSize:      98232 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23228 KB
VmRSS:       23224 KB
VmData:      36340 KB
VmStk:         136 KB
VmExe:          16 KB
VmLib:       56168 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16003 TID = 16003
16003 16007 16008 16051 

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
436f3000 436f6000 rwxp [stack:16008]
436f6000 436fa000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43701000 43702000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43702000 43706000 rwxs /dev/mali
43707000 4370a000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43711000 43712000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43713000 43f12000 rwxp [stack:16007]
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
4431e000 44b1d000 rwxp [stack:16051]
4531d000 45320000 r-xs /opt/home/app/.cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45320000 45324000 r-xs /opt/home/app/.cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45324000 45333000 r-xs /opt/home/app/.cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45333000 453be000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
453be000 453fe000 rwxs /dev/mali
45600000 45640000 rwxs /dev/mali
45640000 45643000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4564a000 4564b000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4564b000 4564c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45653000 45654000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45654000 45678000 rwxs /dev/mali
45678000 4567c000 rwxs /dev/mali
4567c000 456a0000 rwxs /dev/mali
456a0000 456a4000 rwxs /dev/mali
456a4000 456c8000 rwxs /dev/mali
456c8000 456cc000 rwxs /dev/mali
457cc000 457d0000 rwxs /dev/mali
457d0000 457e0000 rwxs /dev/mali
457e0000 457e7000 r-xs /usr/lib/gconv/gconv-modules.cache
457e7000 45873000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
45873000 45878000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
4587f000 45880000 rwxp /usr/lib/scim-1.0/1.4.0/Config/socket.so
45880000 4599f000 r-xp /usr/share/locale/locale-archive
4599f000 459af000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
459b6000 459b7000 rwxp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
459b7000 459bb000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/scim.mo
459bb000 459bc000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
459c3000 459c4000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
459c4000 45a4c000 rwxs /dev/mali
45a4c000 45a4d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a54000 45a55000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a55000 45a65000 rwxs /dev/mali
45a6a000 45a71000 r-xp /usr/lib/libfeedback.so.0.1.4
45a79000 45a7a000 rwxp /usr/lib/libfeedback.so.0.1.4
45a7a000 45a7b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a82000 45a83000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
45a83000 45a85000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
45a8c000 45a8d000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
45a8d000 45a97000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45a9e000 45a9f000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45a9f000 45aa6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45aad000 45aae000 rwxp /usr/lib/libmmfcommon.so.0.0.0
45aae000 45ab3000 r-xp /usr/lib/libmmfsession.so.0.0.0
45aba000 45abb000 rwxp /usr/lib/libmmfsession.so.0.0.0
45abb000 45ac5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45acd000 45ace000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
45af8000 45afc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45b04000 45b05000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
45b05000 45b0a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45b11000 45b12000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
45b20000 45b36000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b3e000 45b3f000 rwxp /usr/lib/libmmfsound.so.0.1.0
45b48000 45b5e000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45b66000 45b67000 rwxp /usr/lib/libavsysaudio.so.0.0.1
45b67000 45b6a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b71000 45b72000 rwxp /usr/lib/libpulse-simple.so.0.0.4
45b72000 45baa000 r-xp /usr/lib/libpulse.so.0.16.2
45baa000 45bab000 rwxp /usr/lib/libpulse.so.0.16.2
45bab000 45bae000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45bb5000 45bb6000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
45bb8000 45bf8000 rwxs /dev/mali
45bf8000 45c24000 rwxs /dev/mali
45c24000 45c31000 r-xp /usr/lib/libail.so.0.1.0
45c39000 45c3a000 rwxp /usr/lib/libail.so.0.1.0
45c3a000 45c3d000 r-xp /usr/lib/libcompress.so.0.2.0
45c44000 45c45000 rwxp /usr/lib/libcompress.so.0.2.0
45c5c000 45c64000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45c6b000 45c6c000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
45c73000 45c78000 r-xp /usr/lib/libjson.so.0.0.1
45c7f000 45c80000 rwxp /usr/lib/libjson.so.0.0.1
45c84000 45ce5000 r-xp /usr/lib/libasound.so.2.0.0
45cec000 45cef000 rwxp /usr/lib/libasound.so.2.0.0
45cef000 45cff000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45cff000 45d03000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
45d20000 45d68000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d68000 45d69000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d69000 45dac000 r-xp /usr/lib/libsndfile.so.1.0.25
45db3000 45db5000 rwxp /usr/lib/libsndfile.so.1.0.25
45db9000 45ddb000 r-xp /usr/lib/libvorbis.so.0.4.3
45de2000 45de3000 rwxp /usr/lib/libvorbis.so.0.4.3
45de3000 45de7000 r-xp /usr/lib/libogg.so.0.7.1
45dee000 45def000 rwxp /usr/lib/libogg.so.0.7.1
be912000 be933000 rwxp [stack]
End of Maps Information

Callstack Information (PID:16003)
Call Stack Count: 1
 0: create_third_page + 0x1b (0x40002e38) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x2e38
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
editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-02 14:49:59.133+0900 W/W_HOME  (  731): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
04-02 14:49:59.133+0900 W/W_HOME  (  731): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
04-02 14:49:59.133+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
04-02 14:49:59.133+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
04-02 14:49:59.408+0900 W/W_HOME  (  731): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
04-02 14:49:59.408+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-02 14:49:59.408+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47906410
04-02 14:49:59.408+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47906410, elm_layout, func : 0x4004b469
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47906410, activated : 1
04-02 14:49:59.413+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:49:59.413+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:49:59.413+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:49:59.413+0900 W/W_HOME  (  731): event_manager.c: _apptray_visibility_cb(578) > apps,show
04-02 14:49:59.418+0900 W/W_HOME  (  731): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
04-02 14:49:59.418+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:49:59.418+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:49:59.418+0900 W/W_HOME  (  731): main.c: home_pause(751) > clock/widget paused
04-02 14:49:59.418+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:49:59.418+0900 W/APPS    (  731): apps_main.c: _time_changed_cb(295) >  date : 2->2
04-02 14:49:59.418+0900 W/W_HOME  (  731): rotary.c: rotary_attach(138) > rotary_attach:0x47890470
04-02 14:49:59.418+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47890470, elm_layout, _activated_obj : 0x45c95d10, activated : 1
04-02 14:49:59.418+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:49:59.418+0900 W/W_HOME  (  731): noti_broker.c: _apptray_visibility_cb(788) > apps,show
04-02 14:49:59.423+0900 W/W_HOME  (  731): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
04-02 14:49:59.423+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
04-02 14:49:59.423+0900 I/wnotib  (  731): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
04-02 14:49:59.423+0900 E/APPS    (  731): apps_main.c: apps_main_resume(621) >  resumed already
04-02 14:49:59.428+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:49:59.428+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:49:59.428+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:49:59.428+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:49:59.513+0900 E/SHealth_Common( 1027): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
04-02 14:49:59.533+0900 W/W_HOME  (  731): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
04-02 14:49:59.938+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
04-02 14:49:59.943+0900 E/EFL     (  731): evas_main<731> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8589078 button=1 downs=1
04-02 14:49:59.943+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [169, 244]
04-02 14:50:00.003+0900 E/EFL     (  731): evas_main<731> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8589132 button=1 downs=0
04-02 14:50:00.003+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [169, 244]->[172, 234]
04-02 14:50:00.008+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,18]
04-02 14:50:00.013+0900 E/APPS    (  731): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-02 14:50:00.013+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(410) >  item(ph1) launched, open(0)
04-02 14:50:00.018+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 0
04-02 14:50:00.023+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(1702) > caller pid : 731
04-02 14:50:00.023+0900 I/AUL_AMD (  473): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
04-02 14:50:00.033+0900 W/AUL_AMD (  473): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 16003
04-02 14:50:00.038+0900 I/APP_CORE(16003): appcore-efl.c: __do_app(429) > [APP 16003] Event: RESET State: PAUSED
04-02 14:50:00.038+0900 I/CAPI_APPFW_APPLICATION(16003): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-02 14:50:00.038+0900 I/APP_CORE(16003): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
04-02 14:50:00.038+0900 I/APP_CORE(16003): appcore-efl.c: __do_app(481) > [APP 16003] App already running, raise the window
04-02 14:50:00.043+0900 W/AUL_AMD (  473): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(16003), cmd(0)
04-02 14:50:00.048+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:50:00.053+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04800003)
04-02 14:50:00.058+0900 I/APP_CORE(16003): appcore-efl.c: __do_app(485) > [APP 16003] Call the resume_cb
04-02 14:50:00.058+0900 I/CAPI_APPFW_APPLICATION(16003): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-02 14:50:00.108+0900 W/AUL_AMD (  473): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-02 14:50:00.108+0900 W/AUL_AMD (  473): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
04-02 14:50:00.113+0900 I/APP_CORE(16003): appcore-efl.c: __do_app(429) > [APP 16003] Event: RESUME State: RUNNING
04-02 14:50:00.128+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-02 14:50:00.133+0900 I/MALI    (  731): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1460] swap changed from sync to async
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.148+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
04-02 14:50:00.148+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.153+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
04-02 14:50:00.153+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:50:00.153+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:00.158+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
04-02 14:50:00.158+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:50:00.158+0900 W/W_HOME  (  731): main.c: _appcore_pause_cb(690) > appcore pause
04-02 14:50:00.158+0900 W/W_HOME  (  731): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
04-02 14:50:00.158+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.163+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.163+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:50:00.163+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47890470
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47890470, elm_layout, func : 0x4004b469
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47890470, activated : 1
04-02 14:50:00.163+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:50:00.163+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:50:00.168+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:50:00.173+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:50:00.173+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:50:00.173+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [false][0m
04-02 14:50:00.178+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:00.178+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : pedometer_inactive_period error
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_10min_precaution_millisec error
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:50:00.188+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_before_10min_precaution_millisec error
04-02 14:50:00.228+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
04-02 14:50:00.228+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:50:00.243+0900 W/APPS    (  731): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
04-02 14:50:00.408+0900 W/APPS    (  731): apps_main.c: _time_changed_cb(295) >  date : 2->2
04-02 14:50:00.478+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:50:00.678+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:50:00.838+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8589972 button=1 downs=1
04-02 14:50:00.883+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8590020 button=1 downs=0
04-02 14:50:01.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:01.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:01.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:01.688+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:01.693+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:01.698+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:01.798+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:true] pos=0[0m
04-02 14:50:01.838+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:01.838+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:01.908+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:01.918+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
04-02 14:50:01.948+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:02.028+0900 E/AUL_AMD (  473): amd_appinfo.c: appinfo_get_value(999) > appinfo get value: Invalid argument, 9
04-02 14:50:02.363+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:02.363+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:02.468+0900 I/MALI    (16003): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42ef9590] swap changed from sync to async
04-02 14:50:03.233+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8592369 button=1 downs=1
04-02 14:50:03.278+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8592416 button=1 downs=0
04-02 14:50:03.283+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:03.308+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:03.313+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:03.328+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:03.328+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:03.328+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:03.328+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:03.333+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:03.388+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:03.388+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:03.418+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:03.423+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:03.453+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:03.453+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:03.468+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:03.818+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:05.188+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:50:05.553+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:05.583+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:05.763+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:05.783+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:05.913+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:05.933+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:06.473+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8595604 button=1 downs=1
04-02 14:50:06.568+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8595707 button=1 downs=0
04-02 14:50:06.573+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:06.608+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:06.613+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:06.628+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:06.628+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:06.628+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:06.628+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:06.633+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:06.688+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:06.688+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:06.723+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:06.723+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:06.758+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:06.758+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:06.778+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:07.118+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:07.208+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:07.233+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:07.413+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:07.443+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:07.653+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:07.668+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:10.238+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8599374 button=1 downs=1
04-02 14:50:10.278+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8599414 button=1 downs=0
04-02 14:50:10.548+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8599685 button=1 downs=1
04-02 14:50:10.633+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8599768 button=1 downs=0
04-02 14:50:10.633+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:10.668+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:10.678+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:10.693+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:10.693+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:10.693+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:10.693+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:10.703+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:10.768+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:10.768+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:10.803+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:10.803+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:10.838+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:10.843+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:10.863+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:11.183+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:11.368+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:11.408+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:11.533+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:11.568+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:11.753+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8600888 button=1 downs=1
04-02 14:50:11.798+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8600937 button=1 downs=0
04-02 14:50:11.803+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:11.828+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:11.833+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:11.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:50:11.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:50:11.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:50:11.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:50:11.843+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:11.883+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:50:11.883+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:11.908+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:50:11.908+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:50:11.948+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
04-02 14:50:11.948+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
04-02 14:50:11.958+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:50:11.958+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:50:11.978+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:50:12.333+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:12.378+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:12.418+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:50:12.663+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:12.683+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:50:12.853+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:50:12.863+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:50:13.863+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:50:13.913+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x4800003 FAILED!
04-02 14:50:14.113+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_clear(121) > [0;31mrotary_input_clear[0m
04-02 14:50:14.113+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
04-02 14:50:14.113+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
04-02 14:50:14.113+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
04-02 14:50:14.113+0900 E/ISE_MULTI(  995): rotary_input.cpp: destroy_rotary_input_layout(622) > [0;31mdestroy_rotary_input_layout[0m
04-02 14:50:14.113+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:14.378+0900 I/MALI    (16003): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42ef9590] swap changed from async to sync
04-02 14:50:14.553+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8603690 button=1 downs=1
04-02 14:50:14.593+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8603729 button=1 downs=0
04-02 14:50:14.593+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:true][0m
04-02 14:50:14.623+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:50:14.633+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:50:14.653+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:14.888+0900 D/IP      (16003): 192.168.43.165
04-02 14:50:14.888+0900 D/PORT    (16003): 7777
04-02 14:50:14.888+0900 I/IP      (16003): 192.168.43.165
04-02 14:50:15.158+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:50:21.393+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 546
04-02 14:50:21.393+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [546 / 546] bytes
04-02 14:50:21.408+0900 E/wnoti-service(  857): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(535)
04-02 14:50:21.408+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
04-02 14:50:21.408+0900 E/wnoti-service(  857): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1490
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 143
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:21.413+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1490
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3981) > image is not in gear
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3992) > images are not completed
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-sap-client.c: publish_received_noti(1848) > 1000, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230240, noti_flag : 528, g_span_version : 1
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-sap-client.c: publish_received_noti(2149) > req_app_data_timer : 0
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_received_noti(2772) > INCOMPLETE IMAGES, application_id : 218, seq_num : 230240
04-02 14:50:21.418+0900 E/wnoti-service(  857): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
04-02 14:50:21.423+0900 E/wnoti-service(  857): wnoti-sap-client.c: on_app_data(143) > source : 0, protocol : 0, seq_num : 230240, duplicated_seq_num_count : 0, g_slot_id : 1
04-02 14:50:21.423+0900 E/wnoti-service(  857): wnoti-consumer.c: wnoti_consumer_send(785) > connect: 1, upsm : 0, connection_type : 16, len : 4, SEND HOST: [23][3][83][60][0][0]
04-02 14:50:21.433+0900 E/wnoti-service(  857): wnoti-consumer.c: wnoti_consumer_send(823) > send data success
04-02 14:50:21.433+0900 W/SCSD    ( 5028): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x09)
04-02 14:50:21.433+0900 W/SCSD    ( 5028): <on_sap_socket_recv:30>  - remain length: 9, crc_size: 4
04-02 14:50:21.433+0900 W/SCSD    ( 5028): <on_sap_socket_recv:62>  - recv 13 bytes [13 / 13] 
04-02 14:50:21.438+0900 W/SCSD    ( 5028): <util_scs_send:975> sent [15 / 15] bytes. 
04-02 14:50:21.453+0900 E/PKGMGR  (14209): comm_client_gdbus.c: comm_client_free(283) > Invalid gdbus connection
04-02 14:50:21.453+0900 E/PKGMGR  (14209): pkgmgr.c: pkgmgr_client_free(1520) > [0;31m[pkgmgr_client_free(): 1520](ret < 0) comm_client_free() failed[0;m
04-02 14:50:21.458+0900 I/efl-extension(14209): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-02 14:50:22.043+0900 E/EFL     (16003): evas_main<16003> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8611180 button=1 downs=1
04-02 14:50:22.068+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 8960
04-02 14:50:22.068+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [8960 / 8960] bytes
04-02 14:50:22.078+0900 E/wnoti-service(  857): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(8949)
04-02 14:50:22.078+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
04-02 14:50:22.078+0900 E/wnoti-service(  857): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
04-02 14:50:22.078+0900 E/wnoti-service(  857): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
04-02 14:50:22.093+0900 E/wnoti-service(  857): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:22.103+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1417
04-02 14:50:22.108+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
04-02 14:50:22.133+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1469
04-02 14:50:22.133+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:22.133+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1417
04-02 14:50:22.133+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_1245.png
04-02 14:50:22.133+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1415
04-02 14:50:22.138+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 32768
04-02 14:50:22.138+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [32768 / 32768] bytes
04-02 14:50:22.163+0900 E/EFL     (16003): evas_main<16003> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8611268 button=1 downs=0
04-02 14:50:22.173+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 28852
04-02 14:50:22.173+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [28852 / 28852] bytes
04-02 14:50:22.178+0900 E/wnoti-service(  857): wnoti-db-server.c: _clear_summary_noti(933) > _query_step failed(no row)
04-02 14:50:22.178+0900 E/wnoti-service(  857): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/0
04-02 14:50:22.178+0900 E/wnoti-service(  857): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
04-02 14:50:22.183+0900 E/wnoti-service(  857): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
04-02 14:50:22.183+0900 E/wnoti-service(  857): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230241, noti_flag : 0, g_span_version : 1
04-02 14:50:22.183+0900 E/wnoti-service(  857): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
04-02 14:50:22.188+0900 E/wnoti-service(  857): wnoti-db-server.c: _wnoti_update_category(851) > re_table_id : 0
04-02 14:50:22.193+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 32768
04-02 14:50:22.193+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [32768 / 32768] bytes
04-02 14:50:22.218+0900 E/wnoti-service(  857): wnoti-db-server.c: set_global_noti_count(1557) > pre_count : 0, count : 1
04-02 14:50:22.223+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 28852
04-02 14:50:22.223+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [28852 / 28852] bytes
04-02 14:50:22.233+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 32768
04-02 14:50:22.233+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [32768 / 32768] bytes
04-02 14:50:22.243+0900 I/AUL     (  857): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
04-02 14:50:22.248+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 28852
04-02 14:50:22.248+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [28852 / 28852] bytes
04-02 14:50:22.253+0900 I/AUL     (  857): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
04-02 14:50:22.258+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 32768
04-02 14:50:22.258+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [32768 / 32768] bytes
04-02 14:50:22.258+0900 W/SCSD    ( 5028): <_data_cb:507>  - length: 3313
04-02 14:50:22.258+0900 W/SCSD    ( 5028): <sap_socket_send:137> sent [3313 / 3313] bytes
04-02 14:50:22.268+0900 E/APPS    (  731): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
04-02 14:50:22.268+0900 E/wnoti-service(  857): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
04-02 14:50:22.278+0900 E/wnoti-service(  857): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(220897)
04-02 14:50:22.278+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
04-02 14:50:22.278+0900 E/wnoti-service(  857): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
04-02 14:50:22.283+0900 E/wnoti-service(  857): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
04-02 14:50:22.283+0900 E/wnoti-service(  857): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
04-02 14:50:22.288+0900 E/wnoti-service(  857): wnoti-db-server.c: insert_asset(3797) > [Replace] content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:22.308+0900 E/wnoti-service(  857): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
04-02 14:50:22.308+0900 E/wnoti-service(  857): wnoti-db-server.c: insert_asset(3792) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1490
04-02 14:50:22.323+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1490
04-02 14:50:22.323+0900 E/wnoti-service(  857): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
04-02 14:50:22.323+0900 E/wnoti-service(  857): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 143
04-02 14:50:22.323+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1416
04-02 14:50:22.323+0900 E/wnoti-service(  857): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1490
04-02 14:50:22.658+0900 W/CRASH_MANAGER(16141): worker.c: worker_job(1199) > 1116003706831145957622
