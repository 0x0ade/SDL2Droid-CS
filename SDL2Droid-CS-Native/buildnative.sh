#!/bin/bash
NATIVEDIR=$(dirname "$0")
ndk-build -j 4 NDK_PROJECT_PATH="$NATIVEDIR/../SDL2Droid-CS" NDK_APPLICATION_MK="$NATIVEDIR/Application.mk"
