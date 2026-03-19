package com.MM.ManuscriptMaster.dto.request;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class EpisodeCreateRequest {
    private String heading;
    private int position;
    private String content;
    private Long bookId;
}
