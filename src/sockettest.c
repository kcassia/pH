#include "sockettest.h"
#include "ph1.h"
#include "connection.h"
#include <connection_profile.h>
#include <net_connection.h>
#include <sys/stat.h>
#include <arpa/inet.h>
#include <netdb.h>
#include <net/if.h>
#include <stdbool.h>
#include <stddef.h>
#include <netinet/tcp.h>

#include "C:/tizen-sdk/platforms/tizen-2.3.1/wearable/rootstraps/wearable-2.3.1-emulator.core/usr/include/stdlib.h"

//typedef struct appdata {
////	Evas_Object *win;
////	Evas_Object *conform;
//	Evas_Object *naviframe;
//} appdata_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Evas_Object *label;
	Elm_Object_Item *nf_it;
} appdata_s;

int rotary_count = 1;
char ip[16]={0,};
connection_h connection;


//static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
//{
//	ui_app_exit();
//}
//
//static void win_back_cb(void *data, Evas_Object *obj, void *event_info)
//{
//	appdata_s *ad = data;
//	/* Let window go to hide state. */
//	elm_win_lower(ad->win);
//}


int  inputIP(char input_ip[16]){
	strcpy(ip, input_ip);
	dlog_print(DLOG_INFO, "IP", ip);
	if(ip[0] != 0){
		return 1;
	}else{
		return -1;
	}

}

void initiate(){
	int error_code;

	error_code = connection_create(&connection);
	if (error_code != CONNECTION_ERROR_NONE)
		return;

	char *ip_addr = NULL;
	error_code = connection_get_ip_address(connection,CONNECTION_ADDRESS_FAMILY_IPV4, &ip_addr);
	if (error_code == CONNECTION_ERROR_NONE) {
		free(ip_addr);
	}
}

void remote_control_cb(int index) {

	struct sockaddr_in server_addr;
	int sockfd = -1;

	//Socket 생성
	memset(&server_addr, 0, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(7777);
	server_addr.sin_addr.s_addr = inet_addr(ip);

	//Socket Creation
	if ((sockfd = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "failed to create socket");
		return;
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to create socket");
	}

	//Connection
	if (connect(sockfd, (struct sockaddr*) &server_addr, sizeof(server_addr))< 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "socket connect error: %s\n",strerror(errno));
		close(sockfd);
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to socket connection");
	}

	int count =0;
	char start_msg[] = "START";
	char Go_msg[] = "ENTER";
	char Back_msg[] = "BACK_SPACE";

	//Write
	switch(index){

	case 1:

		if ((count = write(sockfd, start_msg, 12)) < 0) {
			dlog_print(DLOG_INFO, "SOCKETTEST", "write() error: %s\n",strerror(errno));
			close(sockfd);
		} else {
			dlog_print(DLOG_INFO, "SOCKETTEST", "write() 성공\n");
		}
		close(sockfd);
		break;

	case 2:

		if ((count = write(sockfd, Go_msg, 12)) < 0)
		{
		   dlog_print(DLOG_INFO, "SOCKETTEST", "write() error: %s\n", strerror(errno));
		   close(sockfd);
		}else{
			dlog_print(DLOG_INFO, "SOCKETTEST", "write() 성공\n");
		}
		close(sockfd);
		break;

	case 3:

		if ((count = write(sockfd, Back_msg, 12)) < 0)
		{
		   dlog_print(DLOG_INFO, "SOCKETTEST", "write() error: %s\n", strerror(errno));
		   close(sockfd);
		}else{
			dlog_print(DLOG_INFO, "SOCKETTEST", "write() 성공\n");
		}
		close(sockfd);
		break;
	}

}

void start_cb(void *user_data, Evas_Object *obj, void *event_info) {

	struct sockaddr_in server_addr;
	int sockfd = -1;

	//Socket 생성
	memset(&server_addr, 0, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(7777);
	server_addr.sin_addr.s_addr = inet_addr(ip);

	//Socket Creation
	if ((sockfd = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "failed to create socket");
		return;
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to create socket");
	}

	//Connection
	if (connect(sockfd, (struct sockaddr*) &server_addr, sizeof(server_addr))< 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "socket connect error: %s\n",strerror(errno));
		close(sockfd);
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to socket connection");
	}

	int count =0;
	char F5_msg[] = "F5";

	//Write
	if ((count = write(sockfd, F5_msg, 12)) < 0)
	{
	   dlog_print(DLOG_INFO, "SOCKETTEST", "write() error: %s\n", strerror(errno));
	   close(sockfd);
	}else{
		dlog_print(DLOG_INFO, "SOCKETTEST", "write() 성공\n");
	}

	close(sockfd);
}

void esc_cb(void *user_data, Evas_Object *obj, void *event_info) {

	struct sockaddr_in server_addr;
	int sockfd = -1;

	//Socket 생성
	memset(&server_addr, 0, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(7777);
	server_addr.sin_addr.s_addr = inet_addr(ip);

	//Socket Creation
	if ((sockfd = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "failed to create socket");
		return;
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to create socket");
	}

	//Connection
	if (connect(sockfd, (struct sockaddr*) &server_addr, sizeof(server_addr))< 0) {
		dlog_print(DLOG_INFO, "SOCKETTEST", "socket connect error: %s\n",strerror(errno));
		close(sockfd);
	} else {
		dlog_print(DLOG_INFO, "SOCKETTEST", "Success to socket connection");
	}

	int count =0;
	char ECS_msg[] = "ESC";

	//Write
	if ((count = write(sockfd, ECS_msg, 12)) < 0)
	{
	   dlog_print(DLOG_INFO, "SOCKETTEST", "write() error: %s\n", strerror(errno));
	   close(sockfd);
	}else{
		dlog_print(DLOG_INFO, "SOCKETTEST", "write() 성공\n");
	}

	close(sockfd);
}


Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev) {

	if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE && rotary_count == 2) {
		remote_control_cb(2);
		dlog_print(DLOG_INFO, "ROTARTY", "앞으로");
		rotary_count =1;
	} else if (rotary_count == 2) {
		remote_control_cb(3);
		dlog_print(DLOG_INFO, "ROTARTY", "뒤로");
		rotary_count =1;
	} else {
		rotary_count++;
	}

	return EINA_FALSE;
}

void create_third_page(void *data, Evas_Object *obj, void *event_info)
{
//	/* Window */
//	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
//	elm_win_autodel_set(ad->win, EINA_TRUE);
//
//	if (elm_win_wm_rotation_supported_get(ad->win)) {
//		int rots[4] = { 0, 90, 180, 270 };
//		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
//	}
//
//	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
//	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);
//
//	/* Conformant */
//	ad->conform = elm_conformant_add(ad->win);
//	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
//	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
//	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	elm_win_resize_object_add(ad->win, ad->conform);
//	evas_object_show(ad->conform);

//	ad->naviframe = elm_naviframe_add(ad->conform);
//	evas_object_size_hint_weight_set(ad->naviframe, EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
//	elm_object_content_set(ad->conform, ad->naviframe);
//	evas_object_show(ad->naviframe);

	struct appdata *ad = data;
	Elm_Object_Item *nf_it = NULL;

	Evas_Object *layout = elm_box_add(ad->naviframe);

	initiate();
	remote_control_cb(1);

	Evas_Object *box = elm_box_add(layout);
	elm_box_horizontal_set(box, EINA_FALSE);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	elm_naviframe_item_push(ad->naviframe, "Remote Control", NULL, NULL, box, NULL);
	elm_box_padding_set(box, 16, 16);
	evas_object_show(box);

	eext_rotary_event_handler_add(_rotary_handler_cb, NULL);

	Evas_Object *F5button = elm_button_add(box);
	evas_object_size_hint_weight_set(F5button, EVAS_HINT_FILL,EVAS_HINT_FILL);
	evas_object_size_hint_align_set(F5button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(F5button, "Start");
	evas_object_smart_callback_add(F5button, "clicked", start_cb, NULL);
	elm_box_pack_end(box, F5button);
	evas_object_show(F5button);

	Evas_Object *ESCbutton = elm_button_add(box);
	evas_object_size_hint_weight_set(ESCbutton, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_align_set(ESCbutton, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(ESCbutton, "ESC");
	evas_object_smart_callback_add(ESCbutton, "clicked", esc_cb, NULL);
	elm_box_pack_end(box, ESCbutton);
	evas_object_show(ESCbutton);

	nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>Remote Control</color>", NULL, NULL, box, NULL);

	/* Show window after base gui is set up */
//	evas_object_show(ad->win);

}

//static bool app_create(void *data)
//{
//	/* Hook to take necessary actions before main event loop starts
//		Initialize UI resources and application's data
//		If this function returns true, the main loop of application starts
//		If this function returns false, the application is terminated */
//	appdata_s *ad = data;
//
//	create_base_gui(ad);
//
//	return true;
//}
//
//static void app_control(app_control_h app_control, void *data)
//{
//	/* Handle the launch request. */
//}
//
//static void app_pause(void *data)
//{
//	/* Take necessary actions when application becomes invisible. */
//}
//
//static void
//app_resume(void *data)
//{
//	/* Take necessary actions when application becomes visible. */
//}
//
//static void
//app_terminate(void *data)
//{
//	/* Release all resources. */
//}
//
//static void
//ui_app_lang_changed(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_LANGUAGE_CHANGED*/
//	char *locale = NULL;
//	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
//	elm_language_set(locale);
//	free(locale);
//	return;
//}
//
//static void
//ui_app_orient_changed(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
//	return;
//}
//
//static void
//ui_app_region_changed(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_REGION_FORMAT_CHANGED*/
//}
//
//static void
//ui_app_low_battery(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_LOW_BATTERY*/
//}
//
//static void
//ui_app_low_memory(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_LOW_MEMORY*/
//}
//
//int
//main(int argc, char *argv[])
//{
//	appdata_s ad = {0,};
//	int ret = 0;
//
//	ui_app_lifecycle_callback_s event_callback = {0,};
//	app_event_handler_h handlers[5] = {NULL, };
//
//	event_callback.create = app_create;
//	event_callback.terminate = app_terminate;
//	event_callback.pause = app_pause;
//	event_callback.resume = app_resume;
//	event_callback.app_control = app_control;
//
//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
//	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);
//
//	ret = ui_app_main(argc, argv, &event_callback, &ad);
//	if (ret != APP_ERROR_NONE) {
//		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
//	}
//
//	return ret;
//}
