import React from 'react';
import './App.css';
import Header from './header';
import BowlerList from './Bowling/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Your Guide to all things Bowling Crew Bowlers" />
      <BowlerList />
    </div>
  );
}

export default App;
