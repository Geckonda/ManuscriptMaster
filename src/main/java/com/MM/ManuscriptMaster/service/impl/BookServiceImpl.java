package com.MM.ManuscriptMaster.service.impl;

import com.MM.ManuscriptMaster.domain.model.Book;
import com.MM.ManuscriptMaster.domain.model.Genre;
import com.MM.ManuscriptMaster.domain.model.User;
import com.MM.ManuscriptMaster.dto.request.BookCreateRequest;
import com.MM.ManuscriptMaster.dto.request.BookUpdateRequest;
import com.MM.ManuscriptMaster.dto.response.BookResponse;
import com.MM.ManuscriptMaster.dto.response.BookSimpleResponse;
import com.MM.ManuscriptMaster.exception.NotFoundException;
import com.MM.ManuscriptMaster.mapper.BookMapper;
import com.MM.ManuscriptMaster.repository.BookRepository;
import com.MM.ManuscriptMaster.repository.GenreRepository;
import com.MM.ManuscriptMaster.repository.UserRepository;
import com.MM.ManuscriptMaster.service.BookService;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class BookServiceImpl implements BookService {
    
    private final BookRepository bookRepository;
    private final UserRepository userRepository;
    private final GenreRepository genreRepository;
    private final BookMapper bookMapper;

    @Override
    public List<BookSimpleResponse> getBooksPreview() {
        return bookRepository.findAll().stream()
                .map(bookMapper::toPreviewResponse)
                .collect(Collectors.toList());
    }

    @Override
    public List<BookResponse> getBooksDetailed() {
        return bookRepository.findAll().stream()
                .map(bookMapper::toDetailedResponse)
                .collect(Collectors.toList());
    }

    @Override
    public BookSimpleResponse getBookPreview(Long id) {
        Book book = bookRepository.findById(id)
                .orElseThrow(() -> new NotFoundException("Book not found with id " + id));
        return bookMapper.toPreviewResponse(book);
    }

    @Override
    public BookResponse getBook(Long id) {
        Book book = bookRepository.findById(id)
                .orElseThrow(() -> new NotFoundException("Book not found with id " + id));
        return bookMapper.toDetailedResponse(book);
    }

    @Override
    public BookResponse create(BookCreateRequest request) {
        User author = userRepository.findById(request.getAuthorId())
                .orElseThrow(() -> new NotFoundException("User not found with id " + request.getAuthorId()));

        Genre genre = null;
        if (request.getGenreId() != null) {
            genre = genreRepository.findById(request.getGenreId())
                    .orElseThrow(() -> new NotFoundException("Genre not found with id " + request.getGenreId()));
        }

        Book book = Book.builder()
                .title(request.getTitle())
                .author(author)
                .genre(genre)
                .rating(request.getRating())
                .status(request.getStatus())
                .modificator(request.getModificator())
                .build();

        Book savedBook = bookRepository.save(book);
        return bookMapper.toDetailedResponse(savedBook);
    }

    @Override
    public BookResponse update(Long id, BookUpdateRequest request) {
        Book book = bookRepository.findById(id)
                .orElseThrow(() -> new NotFoundException("Book not found with id " + id));

        book.setTitle(request.getTitle());
        
        if (request.getGenreId() != null) {
            Genre genre = genreRepository.findById(request.getGenreId())
                    .orElseThrow(() -> new NotFoundException("Genre not found with id " + request.getGenreId()));
            book.setGenre(genre);
        }

        if (request.getRating() != null) {
            book.setRating(request.getRating());
        }
        if (request.getStatus() != null) {
            book.setStatus(request.getStatus());
        }
        if (request.getModificator() != null) {
            book.setModificator(request.getModificator());
        }

        Book updatedBook = bookRepository.save(book);
        return bookMapper.toDetailedResponse(updatedBook);
    }

    @Override
    public void delete(Long id) {
        Book book = bookRepository.findById(id)
                .orElseThrow(() -> new NotFoundException("Book not found with id " + id));
        bookRepository.delete(book);
    }
}
