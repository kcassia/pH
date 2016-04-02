#ifndef __ph1_H__
#define __ph1_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "ph1"

#if !defined(PACKAGE)
#define PACKAGE "org.example.ph1"
#endif

void clicked_cb(void *data, Evas_Object *obj, void *event_info);

#endif /* __ph1_H__ */
