import React from 'react';
import './ProgressBar.css';

interface ProgressBarProps {
  value: number;
  color?: string;
  className?: string;
}

const ProgressBar: React.FC<ProgressBarProps> = ({ 
  value, 
  color = '#224A72FF',
  className = '' 
}) => {
  return (
    <div className={`progress-bar ${className}`}>
      <div
        className="progress-bar-fill"
        style={{
          width: `${value}%`,
          backgroundColor: color,
        }}
      />
    </div>
  );
};

export default ProgressBar;
