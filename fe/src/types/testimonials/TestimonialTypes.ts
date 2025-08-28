import type { BaseEntity } from '../common/BaseTypes';

export interface Testimonial extends BaseEntity {
  name: string;
  title: string;
  company: string;
  avatar: string;
  content: string;
  rating: number; // 1-5
  date: Date;
}
