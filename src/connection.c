#include "connection.h"
#include "ph1.h"
#include "sockettest.h"
#include <string.h>
#include <stdio.h>
#include <dlog.h>

//typedef struct appdata {
//	Evas_Object *win;
//	Evas_Object *conform;
//	Evas_Object *label;
//	Evas_Object *naviFrame;
//} appdata_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Evas_Object *label;
	Elm_Object_Item *nf_it;
} appdata_s;

Evas_Object *ipEntry1;
Evas_Object *ipEntry2;
Evas_Object *ipEntry3;
Evas_Object *ipEntry4;
Evas_Object *portEntry;

const char *ipEntry_1;
const char *ipEntry_2;
const char *ipEntry_3;
const char *ipEntry_4;
const char *port_final;
char ip_final[16] = { 0, };

//static void win_delete_request_cb(void *data, Evas_Object *obj,
//      void *event_info) {
//   ui_app_exit();
//}
//
//static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
//   appdata_s *ad = data;
//   /* Let window go to hide state. */
//   elm_win_lower(ad->win);
//}

void _connect_button_click_cb(void *data, Evas_Object *connect_button, void *ev) {
	int check = -1;

	ipEntry_1 = elm_entry_entry_get(ipEntry1);
	ipEntry_2 = elm_entry_entry_get(ipEntry2);
	ipEntry_3 = elm_entry_entry_get(ipEntry3);
	ipEntry_4 = elm_entry_entry_get(ipEntry4);

	strcpy(ip_final, ipEntry_1);
	strcat(ip_final, ".");
	strcat(ip_final, ipEntry_2);
	strcat(ip_final, ".");
	strcat(ip_final, ipEntry_3);
	strcat(ip_final, ".");
	strcat(ip_final, ipEntry_4);

	port_final = elm_entry_entry_get(portEntry);


	dlog_print(DLOG_DEBUG, "IP", ip_final);
	dlog_print(DLOG_DEBUG, "PORT", port_final);

	check = inputIP(&ip_final);
	if(check >0){
		elm_object_text_set(connect_button, "Complete");
	}else{
		elm_object_text_set(connect_button, "Fail");
	}

}

void create_second_page(void *data, Evas_Object *connect_button, void *ev) {

//   // Window
//   ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
//   elm_win_autodel_set(ad->win, EINA_TRUE);
//   evas_object_smart_callback_add(ad->win, "delete,request",
//         win_delete_request_cb, NULL);
//
//   // Conformant
//   ad->conform = elm_conformant_add(ad->win);
//   evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
//   EVAS_HINT_EXPAND);
//   elm_win_resize_object_add(ad->win, ad->conform);
//   evas_object_show(ad->conform);

// Naviframe
//	ad->naviFrame = elm_naviframe_add(ad->conform);
//	elm_object_content_set(ad->conform, ad->naviFrame);
//	evas_object_show(ad->naviFrame);

	struct appdata *ad = data;
	Elm_Object_Item *nf_it = NULL;

	Evas_Object *layout = elm_box_add(ad->naviframe);

	// Outer Box
	Evas_Object* box = elm_box_add(layout);
	evas_object_size_hint_weight_set(box, EVAS_HINT_FILL, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_align_set(box, 0.5, 0.5);

	// Port Box
	Evas_Object* box2 = elm_box_add(layout);
	elm_box_horizontal_set(box2, EINA_TRUE);

	// Port Label
	Evas_Object* portLabel = elm_label_add(box);
	elm_object_text_set(portLabel, "<align = center>Port </align>");
	elm_box_pack_end(box2, portLabel);
	evas_object_show(portLabel);

	// Port Entry
	portEntry = elm_entry_add(box2);
	elm_entry_entry_set(portEntry, "7777");
	elm_entry_single_line_set(portEntry, EINA_FALSE);
	elm_entry_line_wrap_set(portEntry, ELM_WRAP_NONE);
	static Elm_Entry_Filter_Limit_Size portLimit_size = { .max_char_count = 5,
			.max_byte_count = 0 };
	elm_entry_markup_filter_append(portEntry, elm_entry_filter_limit_size,
			&portLimit_size);
	elm_box_pack_end(box2, portEntry);
	evas_object_show(portEntry);

	evas_object_show(box2);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, 0.3);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, box2);

	// IP Box
	Evas_Object* box1 = elm_box_add(layout);
	elm_box_horizontal_set(box1, EINA_TRUE);

	// IP Label
	Evas_Object* ipLabel = elm_label_add(box1);
	elm_object_text_set(ipLabel, "<align = center>IP </align>");
	elm_box_pack_end(box1, ipLabel);
	evas_object_show(ipLabel);

	static Elm_Entry_Filter_Limit_Size ipLimit_size = { .max_char_count = 3, // 3글자 까지
			.max_byte_count = 0 };

	// IP Entry
	ipEntry1 = elm_entry_add(box1);
	//elm_entry_entry_set(ipEntry1, "127");
	elm_entry_single_line_set(ipEntry1, EINA_FALSE);
	elm_entry_line_wrap_set(ipEntry1, ELM_WRAP_NONE);
	elm_entry_markup_filter_append(ipEntry1, elm_entry_filter_limit_size,
			&ipLimit_size);
	elm_box_pack_end(box1, ipEntry1);
	evas_object_show(ipEntry1);

	// IP Label
	Evas_Object* ipPeriod1 = elm_label_add(box1);
	elm_object_text_set(ipPeriod1, "<align = center>.</align>");
	elm_box_pack_end(box1, ipPeriod1);
	evas_object_show(ipPeriod1);

	// IP Entry
	ipEntry2 = elm_entry_add(box1);
	//elm_entry_entry_set(ipEntry2, "  0");
	elm_entry_single_line_set(ipEntry2, EINA_FALSE);
	elm_entry_line_wrap_set(ipEntry2, ELM_WRAP_NONE);
	elm_entry_markup_filter_append(ipEntry2, elm_entry_filter_limit_size,
			&ipLimit_size);
	elm_box_pack_end(box1, ipEntry2);
	evas_object_show(ipEntry2);

	// IP Label
	Evas_Object* ipPeriod2 = elm_label_add(box1);
	elm_object_text_set(ipPeriod2, "<align = center>.</align>");
	elm_box_pack_end(box1, ipPeriod2);
	evas_object_show(ipPeriod2);

	// IP Entry
	ipEntry3 = elm_entry_add(box1);
	//elm_entry_entry_set(ipEntry3, "  0");
	elm_entry_single_line_set(ipEntry3, EINA_FALSE);
	elm_entry_line_wrap_set(ipEntry3, ELM_WRAP_NONE);
	elm_entry_markup_filter_append(ipEntry3, elm_entry_filter_limit_size,
			&ipLimit_size);
	elm_box_pack_end(box1, ipEntry3);
	evas_object_show(ipEntry3);

	// IP Label
	Evas_Object* ipPeriod3 = elm_label_add(box1);
	elm_object_text_set(ipPeriod3, "<align = center>.</align>");
	elm_box_pack_end(box1, ipPeriod3);
	evas_object_show(ipPeriod3);

	// IP Entry
	ipEntry4 = elm_entry_add(box1);
	//elm_entry_entry_set(ipEntry4, "  1");
	elm_entry_single_line_set(ipEntry4, EINA_FALSE);
	elm_entry_line_wrap_set(ipEntry4, ELM_WRAP_NONE);
	elm_entry_markup_filter_append(ipEntry4, elm_entry_filter_limit_size,
			&ipLimit_size);
	elm_box_pack_end(box1, ipEntry4);
	evas_object_show(ipEntry4);

	evas_object_show(box1);
	evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, 0.3);
	evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, box1);

	// Connect Button
	Evas_Object* connection_button = elm_button_add(box);
	elm_object_style_set(connection_button, "bottom");
	elm_object_text_set(connection_button, "Connect");
	evas_object_size_hint_weight_set(connection_button, EVAS_HINT_EXPAND, 1.0);
	evas_object_size_hint_align_set(connection_button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_smart_callback_add(connection_button, "clicked", _connect_button_click_cb, NULL);
	elm_box_pack_end(box, connection_button);
	evas_object_show(connection_button);

	evas_object_show(box);
//	elm_naviframe_item_push(ad->naviFrame, "Connection", NULL, NULL, box,
//			"basic");

	elm_entry_input_panel_layout_set(ipEntry1,
			ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
	elm_entry_input_panel_layout_set(ipEntry2,
			ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
	elm_entry_input_panel_layout_set(ipEntry3,
			ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
	elm_entry_input_panel_layout_set(ipEntry4,
			ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
	elm_entry_input_panel_layout_set(portEntry,
			ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);

	nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>PH</color>", NULL, NULL, box, NULL);

//	evas_object_show(ad->win);
}

//static bool app_create(void *data) {
//	/* Hook to take necessary actions before main event loop starts
//	 Initialize UI resources and application's data
//	 If this function returns true, the main loop of application starts
//	 If this function returns false, the application is terminated */
//	appdata_s *ad = data;
//
//	create_base_gui(ad);
//
//	return true;
//}

//static void app_control(app_control_h app_control, void *data) {
//	/* Handle the launch request. */
//}
//
//static void app_pause(void *data) {
//	/* Take necessary actions when application becomes invisible. */
//}
//
//static void app_resume(void *data) {
//	/* Take necessary actions when application becomes visible. */
//}
//
//static void app_terminate(void *data) {
//	/* Release all resources. */
//}

//static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
//	/*APP_EVENT_LANGUAGE_CHANGED*/
//	char *locale = NULL;
//	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
//			&locale);
//	elm_language_set(locale);
//	free(locale);
//	return;
//}
//
//static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
//	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
//	return;
//}
//
//static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
//	/*APP_EVENT_REGION_FORMAT_CHANGED*/
//}
//
//static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
//	/*APP_EVENT_LOW_BATTERY*/
//}
//
//static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
//	/*APP_EVENT_LOW_MEMORY*/
//}

//int main(int argc, char *argv[]) {
//	appdata_s ad = { 0, };
//	int ret = 0;
//
//	ui_app_lifecycle_callback_s event_callback = { 0, };
//	app_event_handler_h handlers[5] = { NULL, };
//
//	event_callback.create = app_create;
//	event_callback.terminate = app_terminate;
//	event_callback.pause = app_pause;
//	event_callback.resume = app_resume;
//	event_callback.app_control = app_control;
//
//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
//			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
//			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
//			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
//			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
//			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
//	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);
//
//	ret = ui_app_main(argc, argv, &event_callback, &ad);
//	if (ret != APP_ERROR_NONE) {
//		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
//	}
//
//	return ret;
//}
