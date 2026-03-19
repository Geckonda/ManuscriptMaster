package com.MM.ManuscriptMaster.mapper;

import com.MM.ManuscriptMaster.domain.model.Genre;
import com.MM.ManuscriptMaster.dto.response.GenreSimpleResponse;
import org.springframework.stereotype.Component;

@Component
public class GenreMapper {

    public GenreSimpleResponse toSimpleResponse(Genre genre) {
        if (genre == null) {
            return null;
        }
        return GenreSimpleResponse.builder()
                .id(genre.getId())
                .name(genre.getName())
                .description(genre.getDescription())
                .build();
    }
}
