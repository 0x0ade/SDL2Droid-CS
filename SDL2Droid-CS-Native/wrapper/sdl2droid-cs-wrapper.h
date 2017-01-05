#ifndef SDL2DROID-CS_WRAPPER_H
#define SDL2DROID-CS_WRAPPER_H

#include <android/log.h>

#define  LOG_TAG    "SDL2DROID-CS-wrapper"
#define  LOGI(...)  __android_log_print(ANDROID_LOG_INFO,LOG_TAG,__VA_ARGS__)
#define  LOGW(...)  __android_log_print(ANDROID_LOG_WARN,LOG_TAG,__VA_ARGS__)
#define  LOGE(...)  __android_log_print(ANDROID_LOG_ERROR,LOG_TAG,__VA_ARGS__)

// We're passing a function pointer to "return" to C# land here
typedef void (*Main)();
Main CurrentMain;

void SetMain(Main main);

#endif
