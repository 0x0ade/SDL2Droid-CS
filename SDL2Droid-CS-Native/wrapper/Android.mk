LOCAL_PATH := $(call my-dir)

###########################
#
# SDL2Droid-CS wrapper
#
###########################

include $(CLEAR_VARS)
LOCAL_MODULE := main
LOCAL_SRC_FILES := sdl2droid-cs-wrapper.c ../../deps/SDL/src/main/android/SDL_android_main.c
LOCAL_LDLIBS := -llog -landroid -lm -ldl
LOCAL_SHARED_LIBRARIES := SDL2
LOCAL_CFLAGS += -Ideps/SDL/include -D_REENTRANT
include $(BUILD_SHARED_LIBRARY)
