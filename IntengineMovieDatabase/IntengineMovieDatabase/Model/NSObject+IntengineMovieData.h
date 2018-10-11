//
//  NSObject+IntengineMovieData.h
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 11/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface IntengineMovieData : NSObject

@property (strong) NSString *title;
@property (assign) float rating;

- (id)initWithTitle:(NSString*)title rating:(float)rating;

@end
