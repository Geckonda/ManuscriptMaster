package com.MM.ManuscriptMaster.mapper;

import com.MM.ManuscriptMaster.domain.model.Episode;
import com.MM.ManuscriptMaster.dto.response.EpisodeSimpleResponse;
import org.springframework.stereotype.Component;

@Component
public class EpisodeMapper {

    public EpisodeSimpleResponse toSimpleResponse(Episode episode) {
        if (episode == null) {
            return null;
        }
        return EpisodeSimpleResponse.builder()
                .id(episode.getId())
                .heading(episode.getHeading())
                .position(episode.getPosition())
                .content(episode.getContent())
                .build();
    }
}
