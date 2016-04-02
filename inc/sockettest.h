#ifndef __sockettest_H__
#define __sockettest_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "sockettest"

#if !defined(PACKAGE)
#define PACKAGE "org.example.sockettest"
#endif

void initiate();
int inputIP(char *input_ip);
void remote_control_cb(int index);
void start_cb(void *user_data, Evas_Object *obj, void *event_info);
void esc_cb(void *user_data, Evas_Object *obj, void *event_info);
Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev);
void create_third_page(void *data, Evas_Object *obj, void *event_info);


#endif /* __sockettest_H__ */
