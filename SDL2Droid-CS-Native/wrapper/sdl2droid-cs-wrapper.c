#include "sdl2droid-cs-wrapper.h"

#include <errno.h>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

#include <android/log.h>

#define SDL_MAIN_HANDLED
#include <SDL_main.h>
#include <SDL.h>

void SetMain(Main main) {
	CurrentMain = main;
}

int SDL_main(int argc, char* argv[]) {
	CurrentMain();
}
