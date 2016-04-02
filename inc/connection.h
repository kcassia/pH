#ifndef __connection_H__
#define __connection_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "connection"

#if !defined(PACKAGE)
#define PACKAGE "org.example.connection"
#endif

void _connect_button_click_cb(void *data, Evas_Object *connect_button, void *ev);
void create_second_page(void *data, Evas_Object *connect_button, void *ev);

#endif /* __connection_H__ */
