#include "ph1.h"
#include "sockettest.h"
#include "connection.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Evas_Object *label;
	Elm_Object_Item *nf_it;
} appdata_s;

static void win_delete_request_cb(void *data, Evas_Object *obj,void *event_info) {
	ui_app_exit();
}

static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it) {
	ui_app_exit();
	return EINA_FALSE;
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
	elm_naviframe_item_pop(ad->naviframe);
}

static void connect_cb(void *data, Evas_Object *obj, void *event_info) {
//	elm_exit();
	appdata_s *ad = data;
	elm_naviframe_item_pop(ad->naviframe);
	// 앞으로 더 추가해야함!!!!
}

void clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	struct appdata *ad = data;
	Elm_Object_Item *nf_it = NULL;

//	ad->naviframe = elm_naviframe_add(ad->conform);
//	elm_object_content_set(ad->conform, ad->naviframe);
//	evas_object_show(ad->conform);

	Evas_Object *layout = elm_box_add(ad->naviframe);
	//	Evas_Object *box = elm_box_add(ad->naviframe);
	Evas_Object *box = elm_box_add(layout);

	elm_box_horizontal_set(box, EINA_FALSE);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box);

	Evas_Object* box1 = elm_box_add(ad->naviframe);
	elm_box_horizontal_set(box1, EINA_TRUE);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.1);

	Evas_Object *button1 = elm_button_add(box1);
	evas_object_size_hint_weight_set(button1, EVAS_HINT_EXPAND, 0.3);
	evas_object_size_hint_align_set(button1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button1, "<color=#E1FF36FF>   왼손</color>");
	elm_box_pack_end(box1, button1);
	evas_object_show(button1);

	Evas_Object *button2 = elm_button_add(box1);
	evas_object_size_hint_weight_set(button2, EVAS_HINT_EXPAND, 0.3);
	evas_object_size_hint_align_set(button2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button2,"<color=#E1FF36FF><align=left>오른손   </color></align>");
	elm_box_pack_end(box1, button2);
	evas_object_show(button2);

	evas_object_show(box1);
	evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, box1);

	Evas_Object* button = elm_button_add(box);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "Connect");
	evas_object_smart_callback_add(button, "clicked", connect_cb, ad);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, button);
	evas_object_show(button);
	evas_object_show(box);
//	   elm_naviframe_item_push(ad->navi2, "Setting", NULL, NULL, box, "basic");

	nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>PH</color>", NULL, NULL, box, NULL);

	//elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, NULL);

}

static void create_base_gui(appdata_s *ad) {
	/* Window */
//	   ad->win = elm_win_util_standard_add("main", "Button Basic Tutorial");
	Elm_Object_Item *nf_it;
	Evas_Object *layout;

	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
//	   eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	layout = elm_layout_add(ad->naviframe);
//	elm_layout_theme_set(layout,)

	ad->naviframe = elm_naviframe_add(ad->conform);
	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	elm_object_content_set(ad->conform, ad->naviframe);
	evas_object_show(ad->conform);

	Evas_Object *box = elm_box_add(ad->naviframe);
//	Evas_Object *box = elm_box_add(layout);
	elm_box_horizontal_set(box, EINA_FALSE);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	elm_naviframe_item_push(ad->naviframe, "<color=#F5D6FFFF>PH</color>", NULL,
//	NULL, box, NULL);
	evas_object_show(box);

	Evas_Object* box1 = elm_box_add(ad->naviframe);
	elm_box_horizontal_set(box1, EINA_TRUE);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.1);

	char buf[PATH_MAX];
	snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/11.PNG", PACKAGE);

	Evas_Object *img1 = elm_image_add(box1);
	evas_object_size_hint_weight_set(img1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(img1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_image_file_set(img1, buf, NULL);
	elm_object_content_set(box1, img1);
	evas_object_show(img1);

	elm_object_part_content_set(layout, "elm.swallow.btn", img1);

//	elm_object_text_set(button1, "<color=#E1FF36FF>   시작</color>");
	elm_box_pack_end(box1, img1);
	evas_object_show(img1);

	snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/22.PNG", PACKAGE);

	Evas_Object *img2 = elm_image_add(box1);
	evas_object_size_hint_weight_set(img2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(img2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_image_file_set(img2, buf, NULL);
	elm_object_content_set(box1, img2);
	evas_object_show(img2);

	elm_object_part_content_set(layout, "elm.swallow.btn", img2);

	//	elm_object_text_set(button2,
	//			"<color=#E1FF36FF><align=left>기록   </color></align>");
	elm_box_pack_end(box1, img2);
	evas_object_show(img2);

	evas_object_show(box1);
	evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, box1);

	Evas_Object* box2 = elm_box_add(ad->naviframe);
	elm_box_horizontal_set(box2, EINA_TRUE);

	snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/33.PNG", PACKAGE);

	Evas_Object *img3 = elm_image_add(box2);
	evas_object_size_hint_weight_set(img3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(img3, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_style_set(img3, "bottom");
	elm_image_file_set(img3, buf, NULL);
	elm_object_content_set(box2, img3);
	evas_object_show(img3);

	elm_object_part_content_set(layout, "elm.swallow.btn", img3);

//			elm_object_text_set(button3, "<color=#E1FF36FF>   설정</color>");

	elm_box_pack_end(box2, img3);
	evas_object_show(img3);

//////////////////////////////////////////////////////////
	snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/44.PNG", PACKAGE);

	Evas_Object *img4 = elm_image_add(box2);
	evas_object_size_hint_weight_set(img4, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(img4,EVAS_HINT_FILL,EVAS_HINT_FILL);
	elm_image_file_set(img4, buf, NULL);
	elm_object_content_set(box2, img4);
	evas_object_show(img4);

	elm_object_part_content_set(layout, "elm.swallow.btn", img4);

	//	elm_object_text_set(button4, "<color=#E1FF36FF>  연결 </color>");
	evas_object_smart_callback_add(img1, "clicked", create_third_page, ad);
	evas_object_smart_callback_add(img3, "clicked", clicked_cb, ad);
	evas_object_smart_callback_add(img4, "clicked", create_second_page, ad);

	elm_box_pack_end(box2, img4);
	evas_object_show(img4);

	evas_object_show(box2);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, box2);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);

//	nf_it = elm_naviframe_item_push(ad->naviframe, "잉?", NULL, NULL, box, NULL);

	nf_it = elm_naviframe_item_push(ad->naviframe,NULL,NULL,NULL,box,NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, NULL);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
