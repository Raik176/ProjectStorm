#pragma once
#include <string>
#include <string_view>

struct Uri {
    public:
    std::string_view Protocol, Host, Port, Path, QueryString;

    static Uri Parse(const std::string_view& uri) {
        Uri result;

        if (uri.empty()) return result;

        auto uriEnd = uri.end();

        auto queryStart = std::find(uri.begin(), uriEnd, '?');

        auto protocolEnd = uri.begin();
        if (auto protocolStart = std::find(uri.begin(), uriEnd, ':'); protocolStart != uriEnd) {
            if (auto prot = uri.substr(protocolStart - uri.begin(), 3); prot == "://") {
                result.Protocol = uri.substr(0, protocolStart - uri.begin());
                protocolEnd = protocolStart + 3;
            }
        }

        auto hostStart = protocolEnd;
        auto pathStart = std::find(hostStart, uriEnd, '/');

        auto hostEnd = std::find(hostStart, (pathStart != uriEnd) ? pathStart : queryStart, ':');

        result.Host = uri.substr(hostStart - uri.begin(), hostEnd - hostStart);

        if ((hostEnd != uriEnd) && (*hostEnd == ':')) {
            ++hostEnd;
            auto portEnd = (pathStart != uriEnd) ? pathStart : queryStart;
            result.Port = uri.substr(hostEnd - uri.begin(), portEnd - hostEnd);
        }

        if (pathStart != uriEnd) result.Path = uri.substr(pathStart - uri.begin(), queryStart - pathStart);
        if (queryStart != uriEnd) result.QueryString = uri.substr(queryStart - uri.begin(), uriEnd - queryStart);

        return result;
    }

    static std::string CreateUri(const std::string_view Protocol, const std::string_view Host, const std::string_view Port, const std::string_view Path, const std::string_view QueryString) {
        std::string uri;
        if (!Protocol.empty()) uri.append(Protocol).append("://");
        uri.append(Host);
        if (!Port.empty()) uri.append(":").append(Port);
        if (!Path.empty()) uri.append(Path);
        if (!QueryString.empty()) uri.append(QueryString);
        return uri;
    }
};