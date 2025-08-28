import React from 'react';
import Card from '../../common/Card/Card';
import Avatar from '../../common/Avatar/Avatar';
import { testimonialsData } from '../../../data';
import './TestimonialsSection.css';

const TestimonialsSection: React.FC = () => {
  return (
    <div className="container-testimonial">
      <div className="container-testimonial-header">
        <span>Testimonials</span>
      </div>
      <div className="container-testimonial-content">
        {testimonialsData.map((testimonial) => (
          <Card key={testimonial.id} className="container-testimonial-card" hoverable>
            <div className="container-testimonial-card-avatar">
              <Avatar 
                src={testimonial.avatar} 
                alt={`${testimonial.name} Avatar`} 
                size="small"
              />
            </div>
            <div className="container-testimonial-card-description">
              <span>"{testimonial.content}"</span>
            </div>
            <div className="container-testimonial-card-name">
              <span>{testimonial.name}</span>
            </div>
            <div className="container-testimonial-card-title">
              <span>{testimonial.title} at {testimonial.company}</span>
            </div>
          </Card>
        ))}
      </div>
    </div>
  );
};

export default TestimonialsSection;
