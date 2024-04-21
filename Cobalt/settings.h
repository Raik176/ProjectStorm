#pragma once

enum class ECobaltUsage {
	Private,
	Hybrid,
};

#define PROJECT_NAME "Rain"
#define PROJECT_VER "v0.1"
#define URL_PROTOCOL "http"
#define URL_HOST "127.0.0.1"
#define URL_PORT "5595"
// #define USE_MINHOOK

#define SHOW_WINDOWS_CONSOLE

constexpr static ECobaltUsage CobaltUsage = ECobaltUsage::Private;
constexpr bool bIsS13Epic = false;