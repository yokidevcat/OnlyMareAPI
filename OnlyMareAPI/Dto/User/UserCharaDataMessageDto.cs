using OnlyMare.API.Data;
using MessagePack;

namespace OnlyMare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserCharaDataMessageDto(List<UserData> Recipients, CharacterData CharaData, CensusDataDto? CensusDataDto);
