import React, { Component } from 'react';
import './App.css';
import MovieRow from './MovieRow.js';
import $ from 'jquery';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {};
    /*console.log("This is my initializer");*/

    /*const movies = [
        {id: 0, poster_src:"https://image.tmdb.org/t/p/w185/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", title: "Avengers: Infinity War", overview: "Lorem ipsum dolor sit amet."},
        {id: 1, poster_src:"https://image.tmdb.org/t/p/w185/cezWGskPY5x7GaglTTRN4Fugfb8.jpg", title: "The Avengers", overview: "Lorem ipsum dolor sit amet."}
    ]

    var movieRows = [];
    movies.forEach((movie) => {
        console.log(movie.title);
        const movieRow = <MovieRow movie={movie}/>;
        movieRows.push(movieRow);
    });

    this.state = {rows: movieRows};*/

    this.performSearch();
  }

  performSearch() {
      console.log("Perform search using moviedb API");
      const urlString = "https://api.themoviedb.org/3/search/movie?query=marvel&api_key=1b5adf76a72a13bad99b8fc0c68cb085";
      $.ajax({
          url: urlString,
          success: (searchResults) => {
              console.log("Fetched data successfully");
              const results = searchResults.results;

              results.forEach((movie) => {
                  console.log(movie.title);
              });
          },
          error: (xhr, status, err) => {
              console.error("Failed to fetch data");
          }
      });
  }

  render() {
    return (
      <div>

        <table className="titleBar">
          <tbody>
          <tr>
              <td><img alt="app logo" width="100" src="logo.png"/></td>
              <td width="10"></td>
              <td><h1>Intengine Movie Database</h1></td>
          </tr>
          </tbody>
        </table>

          <input className="searchBar" placeholder="Wpisz nazwę filmu"></input>

          {this.state.rows}

      </div>
    );
  }
}

export default App;