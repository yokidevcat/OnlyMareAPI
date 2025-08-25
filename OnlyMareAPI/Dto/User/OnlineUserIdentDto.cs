using OnlyMare.API.Data;
using MessagePack;

namespace OnlyMare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);