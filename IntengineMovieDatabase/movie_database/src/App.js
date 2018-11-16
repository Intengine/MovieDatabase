import React, { Component } from 'react';
import './App.css';
import MovieRow from './MovieRow.js';

class App extends Component {
  constructor(props) {
    super(props);
    console.log("This is my initializer");

    const movies = [
        {id: 0, poster_src:"https://image.tmdb.org/t/p/w185/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", title: "Avengers: Infinity War", overview: "Lorem ipsum dolor sit amet."},
        {id: 1, poster_src:"https://image.tmdb.org/t/p/w185/cezWGskPY5x7GaglTTRN4Fugfb8.jpg", title: "The Avengers", overview: "Lorem ipsum dolor sit amet."}
    ]

    var movieRows = [];
    movies.forEach((movie) => {
        console.log(movie.title);
        const movieRow = <MovieRow movie={movie}/>;
        movieRows.push(movieRow);
    });

    this.state = {rows: movieRows};
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