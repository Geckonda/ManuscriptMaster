package com.MM.ManuscriptMaster.dto.response;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class EpisodeSimpleResponse {
    private Long id;
    private String heading;
    private int position;
    private String content;
}
