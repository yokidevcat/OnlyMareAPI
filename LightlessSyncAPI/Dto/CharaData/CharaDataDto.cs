﻿using OnlyMare.API.Data;

namespace OnlyMare.API.Dto.CharaData;

public record CharaDataDto(string Id, UserData Uploader)
{
    public string Description { get; init; } = string.Empty;
    public DateTime UpdatedDate { get; init; }
}
